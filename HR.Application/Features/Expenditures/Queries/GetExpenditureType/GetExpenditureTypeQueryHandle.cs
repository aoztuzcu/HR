using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureType;

public class GetExpenditureTypeQueryHandle : IRequestHandler<GetExpenditureTypeQuery, IEnumerable<ExpenditureType>>
{
    private readonly IExpenditureTypeRepository expenditureTypeRepository;

    public GetExpenditureTypeQueryHandle(IExpenditureTypeRepository expenditureTypeRepository, IMapper mapper)
    {
        this.expenditureTypeRepository = expenditureTypeRepository;
    }


    async Task<IEnumerable<ExpenditureType>> IRequestHandler<GetExpenditureTypeQuery, IEnumerable<ExpenditureType>>.Handle(GetExpenditureTypeQuery request, CancellationToken cancellationToken)
    {
        var expenditureTypes = await expenditureTypeRepository.GetAllAsync(cancellationToken);

        return expenditureTypes;
    }
}
