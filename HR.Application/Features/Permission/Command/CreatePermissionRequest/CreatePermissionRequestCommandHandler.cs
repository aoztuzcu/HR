using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Contracts.Persistence.Services;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestCommandHandler : IRequestHandler<CreatePermissionRequestCommand, CreatePermissionRequestCommand>
{
    private readonly IPermissionRequestRepository repository;
    private readonly IPermissionTypeRepository permissionTypeRepository;
    private readonly IPersonnelRepository personnelRepository;
    private readonly IMapper mapper;

    public CreatePermissionRequestCommandHandler(IPermissionRequestRepository repository, IMapper mapper, IPersonnelRepository personnelRepository, IPermissionTypeRepository permissionTypeRepository)
    {
        this.repository = repository;
        this.mapper = mapper;
        this.personnelRepository = personnelRepository;
        this.permissionTypeRepository = permissionTypeRepository;
    }

    public async Task<CreatePermissionRequestCommand> Handle(CreatePermissionRequestCommand request, CancellationToken cancellationToken)
    {
        // İzin talebinde bulunacak personel biliyorum.
        var personnel = await personnelRepository.GetByIdAsync(request.PersonnelId, cancellationToken);
        var permissionType = await permissionTypeRepository.Find(x => x.Name == "Yıllık İzin");//Yıllık izin talebinde bulunduysa izin hakkı var mı diye kontrol edilecek.
        if (request.PermissionTypeId == permissionType.Id)
        {
            var availablePermissionAmount = await GetAmountofAnnualAvailablePermission(personnel, cancellationToken);
            if (request.Days > availablePermissionAmount)
                throw new InvalidOperationException("Kullanılabilir izin limitinden fazla izin talep edilemez!");
        }
        var isSameDay = await repository.GetAllAsync(x => x.PersonnelId == request.PersonnelId && x.StartDate == request.StartDate, cancellationToken);
        if (isSameDay.Any())
        {
            throw new InvalidOperationException("Aynı günde farklı bir izin talebi oluşturulamaz. Lütfen tekrar deneyin.");
        }
        var permissionRequest = mapper.Map<PermissionRequest>(request);
        permissionRequest.EndDate = permissionRequest.StartDate.AddDays(permissionRequest.Days);
        var result = await repository.AddAsync(permissionRequest, cancellationToken);
        return mapper.Map<CreatePermissionRequestCommand>(result);
    }

    private async Task<float> GetTotalUsedAnnualPermissionsDaysCount(Guid personnelId, CancellationToken cancellationToken)
    {
        // Onaylanan ve onay bekleyen yıllık izin talepleri liste halinde geldi.
        var permissionType = await permissionTypeRepository.Find(x => x.Name == "Yıllık İzin");
        var permissionRequestList = await repository.GetAllAsync(f => f.PersonnelId == personnelId &&
                                                                      f.ApprovalStatus != ApprovalStatus.Rejected && f.PermissionTypeId== permissionType.Id, cancellationToken);
        var totalAnnualPermissionDaysCount = permissionRequestList.Where(x=>x.ApprovedDate?.Year==DateTime.Now.Year).Sum(x => x.Days);
        return totalAnnualPermissionDaysCount;
    }

    private async Task<float> GetAmountofAnnualAvailablePermission(Personnel personnel, CancellationToken token)
    {
        var annualPermissionDays = await GetAnnualPermissionDaysCount(personnel.HireDate,token);
        var annualUsedPermissionDays = await GetTotalUsedAnnualPermissionsDaysCount(personnel.Id,token);
        return (float) annualPermissionDays-annualUsedPermissionDays;

    }
    private async Task<float> GetAnnualPermissionDaysCount(DateTime hireDate, CancellationToken token)
    {
        // Kural Seti
        // 1 yıl ile 5 yıl arasında çalışan personele 14 gün,
        // 5 yıldan fazla 15 yıldan az çalışan personele 20 gün, 
        // 15 yıl ve daha fazla çalışan personele 26 günden az izin verilemez. 

        // İşe başlama tarihinden bu güne kadar geçen yıl sayısı
        int yearsWorked = DateTime.Now.Year - hireDate.Year;

        // İlk yıl için standart izin gün sayısı
        int permissionDays = 0;

        if (yearsWorked >= 1 && yearsWorked <= 5)
        {
            permissionDays = 14;
        }
        else if (yearsWorked > 5 && yearsWorked < 15)
        {
            permissionDays = 20;
        }
        else if (yearsWorked >= 15)
        {
            permissionDays = 26;
        }
        return permissionDays;
    }
}
