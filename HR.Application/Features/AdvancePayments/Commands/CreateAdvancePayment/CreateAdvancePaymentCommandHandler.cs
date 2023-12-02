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
    private readonly IPersonRepository personRepository;
    private readonly IMapper mapper;
    private readonly ICurrencyService currencyService;

    public CreateAdvancePaymentCommandHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper, ICurrencyService currencyService, IPersonRepository personRepository)
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
            decimal maxAllowedAdvance = GetMaxAllowedAdvance(newEntity.PersonId, cancellationToken);
            decimal totalAdvancesWithinYear = await GetTotalAdvancesWithinYear(newEntity.PersonId, DateTime.Now, cancellationToken);

            if (totalAdvancesWithinYear + newEntity.Amount > maxAllowedAdvance)
                // Avans talebi reddedilebilir veya uygun bir işlem yapılabilir
                throw new InvalidOperationException("Maksimum avans limiti aşıldı.");
                // EN throw new InvalidOperationException("The maximum advance limit has been exceeded.");
        }

        var result = await advancePaymentRepository.AddAsync(newEntity, cancellationToken);
        return mapper.Map<CreateAdvancePaymentCommand>(result);
    }


    private async Task<decimal> GetTotalAdvancesWithinYear(Guid personId, DateTime currentDate, CancellationToken cancellationToken)
    {
        // Belirli bir yıl içinde kullanıcının aldığı toplam avans miktarını hesapla
        decimal totalAdvancesWithinYear = 0;
        var list = await advancePaymentRepository.GetAllAsync(f => f.PersonId == personId &&
                                                                   f.AdvanceType == AdvanceType.Personal &&
                                                                   //f.ApprovalStatus == ApprovalStatus.Approved &&
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
