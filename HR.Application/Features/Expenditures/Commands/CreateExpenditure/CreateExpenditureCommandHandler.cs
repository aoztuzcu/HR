using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;
using HR.Domain.Concrete;
using HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Domain.Enum;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Contracts.Persistence.Services;

namespace HR.Application.Features.Expenditures.Commands.CreateExpenditure;

public class CreateExpenditureCommandHandler : IRequestHandler<CreateExpenditureCommand, CreateExpenditureCommand>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;
    private readonly ICurrencyService currencyService;

    public CreateExpenditureCommandHandler(IExpenditureRepository expenditureRepository, IMapper mapper , ICurrencyService currencyService)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
        this.currencyService = currencyService;
    }
    public async Task<CreateExpenditureCommand> Handle(CreateExpenditureCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Expenditure>(request);
        entity.ExchangeAmount = await GetAmountToTl(request.Amount, request.CurrencyType);
        var result = await expenditureRepository.AddAsync(entity, cancellationToken);
        return mapper.Map<CreateExpenditureCommand>(result);
    }

    private async Task<decimal> GetAmountToTl(decimal amount , CurrencyTypeVM currencyType)
    {
        switch (currencyType)
        {
            case CurrencyTypeVM.Dolar:
                var usdToTryRate = await currencyService.GetExchangeRateAsync("TRY", "USD", DateTime.Now);
                return amount * usdToTryRate;


            case CurrencyTypeVM.Euro:
                var euroToTryRate = await currencyService.GetExchangeRateAsync("TRY", "EUR", DateTime.Now);
                return amount * euroToTryRate;


            default:
               return amount;
        }
    }
}
