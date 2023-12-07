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
    private readonly IPersonnelRepository personnelRepository;
    private readonly IMapper mapper;

    public CreatePermissionRequestCommandHandler(IPermissionRequestRepository repository, IMapper mapper, IPersonnelRepository personnelRepository)
    {
        this.repository = repository;
        this.mapper = mapper;
        this.personnelRepository = personnelRepository;
    }

    public async Task<CreatePermissionRequestCommand> Handle(CreatePermissionRequestCommand request, CancellationToken cancellationToken)
    {
        // İzin talebinde bulunacak personel biliyorum.
        var personnel = await personnelRepository.GetByIdAsync(request.PersonnelId, cancellationToken);

        var permissionRequest = mapper.Map<PermissionRequest>(request);
        var result = await repository.AddAsync(permissionRequest, cancellationToken);
        return mapper.Map<CreatePermissionRequestCommand>(result);
    }

    private async Task<float> GetTotalAnnualPermissionsDaysCount(Guid personnelId, DateTime currentDate, CancellationToken cancellationToken)
    {
        // Onaylanan ve onay bekleyen yıllık izin talepleri liste halinde geldi.
        var permissionRequestList = await repository.GetAllAsync(f => f.PersonnelId == personnelId &&
                                                                      f.ApprovalStatus != ApprovalStatus.Rejected, cancellationToken);
        var totalAnnualPermissionDaysCount = permissionRequestList.Sum(x => x.Days);
        return totalAnnualPermissionDaysCount;
    }

    private float GetAnnualPermissionDaysCount(DateTime hireDate, DateTime currentDate)
    {
        // Kural Seti
        // 1 yıl ile 5 yıl arasında çalışan personele 14 gün,
        // 5 yıldan fazla 15 yıldan az çalışan personele 20 gün, 
        // 15 yıl ve daha fazla çalışan personele 26 günden az izin verilemez. 

        // İşe başlama tarihinden bu güne kadar geçen yıl sayısı
        int yearsWorked = currentDate.Year - hireDate.Year;

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
