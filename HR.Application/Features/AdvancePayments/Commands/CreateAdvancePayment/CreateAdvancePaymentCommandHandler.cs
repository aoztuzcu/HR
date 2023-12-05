using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Contracts.Persistence.Services;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;

public class CreateAdvancePaymentCommandHandler : IRequestHandler<CreateAdvancePaymentCommand, CreateAdvancePaymentCommand>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IPersonnelRepository personRepository;
    private readonly IMapper mapper;
    private readonly ICurrencyService currencyService;

    public CreateAdvancePaymentCommandHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper, ICurrencyService currencyService, IPersonnelRepository personRepository)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
        this.currencyService = currencyService;
        this.personRepository = personRepository;
    }

    public async Task<CreateAdvancePaymentCommand> Handle(CreateAdvancePaymentCommand request, CancellationToken cancellationToken)
    {
        var newEntity = mapper.Map<AdvancePayment>(request);

        // Bireysel Avans Talebi ise
        if (newEntity.AdvanceType == AdvanceType.Personal)
        {
            decimal maxAllowedAdvance = GetMaxAllowedAdvance(newEntity.PersonnelId, cancellationToken);
            decimal totalAdvancesWithinYear = await GetTotalAdvancesWithinYear(newEntity.PersonnelId, DateTime.Now, cancellationToken);
            decimal exchangeAmount = 0;
            decimal rate = 0;
            DateTime date = DateTime.Now;
            
            // eğer saat 15:30'den önce ise bir önceki kur ile hesapla
            // Merkez Bankası günlük kuru 15.30 gibi açıklıyor. Bu saatten sonra veri doluyor.
            // Aksi halde page not found hatası veriyor MB'nin sitesi.
            if (DateTime.Now.TimeOfDay < new TimeSpan(15, 30, 0))
            {
                // Eğer şart sağlanıyorsa bir gün çıkartın
                date = DateTime.Now.AddDays(-1);
            }

            if (newEntity.CurrencyType == CurrencyType.Dolar)
            {
                rate = await currencyService.GetExchangeRateAsync("TRY", "USD", date);
                exchangeAmount = newEntity.Amount * rate;
            }
            else if (newEntity.CurrencyType == CurrencyType.Euro)
            {
                rate = await currencyService.GetExchangeRateAsync("TRY", "EUR", DateTime.Now);
                exchangeAmount = newEntity.Amount * rate;
            }
            else
            { // TL cinsinden veri ekleniyorsa
                exchangeAmount = newEntity.Amount;
            }

            if (totalAdvancesWithinYear + exchangeAmount > maxAllowedAdvance)
                throw new InvalidOperationException("Maksimum avans limiti aşıldı.");
            // EN throw new InvalidOperationException("The maximum advance limit has been exceeded.");
        }

        var result = await advancePaymentRepository.AddAsync(newEntity, cancellationToken);
        return mapper.Map<CreateAdvancePaymentCommand>(result);
    }


    private async Task<decimal> GetTotalAdvancesWithinYear(Guid personnelId, DateTime currentDate, CancellationToken cancellationToken)
    {
        // Belirli bir yıl içinde kullanıcının aldığı toplam avans miktarını hesapla
        decimal totalAdvancesWithinYear = 0;
        var list = await advancePaymentRepository.GetAllAsync(f => f.PersonnelId == personnelId &&
                                                                   f.AdvanceType == AdvanceType.Personal &&
                                                                   f.ApprovalStatus != ApprovalStatus.Rejected &&
                                                                   f.CreatedDate >= new DateTime(currentDate.Year, 1, 1) &&
                                                                   f.CreatedDate <= currentDate, cancellationToken);

        foreach (var item in list)
        {
            decimal exchangeRate = 0;
            if (item.CurrencyType == CurrencyType.Dolar)
            {
                exchangeRate = await currencyService.GetExchangeRateAsync("TRY", "USD", item.CreatedDate);
                totalAdvancesWithinYear += item.Amount * exchangeRate;
            }
            else if (item.CurrencyType == CurrencyType.Euro)
            {
                exchangeRate = await currencyService.GetExchangeRateAsync("TRY", "EUR", item.CreatedDate);
                totalAdvancesWithinYear += item.Amount * exchangeRate;
            }
            else
                totalAdvancesWithinYear += item.Amount;
        }
        return totalAdvancesWithinYear;
    }

    private decimal GetMaxAllowedAdvance(Guid personId, CancellationToken cancellationToken)
    {
        // Kullanıcının maksimum avans limitini hesapla
        return 3 * GetPersonSalary(personId, cancellationToken);
    }
    private decimal GetPersonSalary(Guid personId, CancellationToken cancellationToken)
    {
        // Kullanıcının maaşını getir
        return personRepository.GetByIdAsync(personId, cancellationToken).Result.Salary;
    }

}
