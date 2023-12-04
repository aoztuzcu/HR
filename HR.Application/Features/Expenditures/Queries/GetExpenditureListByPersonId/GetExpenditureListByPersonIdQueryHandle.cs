using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Expenditures.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureListByPersonId;

public class GetExpenditureListByPersonIdQueryHandle : IRequestHandler<GetExpenditureListByPersonIdQuery, IEnumerable<ExpenditureListVM>>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public GetExpenditureListByPersonIdQueryHandle(IExpenditureRepository expenditureRepository,IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<ExpenditureListVM>> Handle(GetExpenditureListByPersonIdQuery request, CancellationToken cancellationToken)
    {
        var list = await expenditureRepository.GetAllByPersonIdAsync(request.PersonnelId, cancellationToken);
        return mapper.Map<IEnumerable<ExpenditureListVM>>(list);
    }
}
