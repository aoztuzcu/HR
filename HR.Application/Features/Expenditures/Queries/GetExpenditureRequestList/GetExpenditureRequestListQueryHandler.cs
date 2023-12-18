using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Expenditures.ViewModels;
using MediatR;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureRequestList;

public class GetExpenditureRequestListQueryHandler : IRequestHandler<GetExpenditureRequestListQuery, IEnumerable<ExpenditureApproveListVM>>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public GetExpenditureRequestListQueryHandler(IExpenditureRepository expenditureRepository, IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<ExpenditureApproveListVM>> Handle(GetExpenditureRequestListQuery request, CancellationToken cancellationToken)
         => mapper.Map<IEnumerable<ExpenditureApproveListVM>>(await expenditureRepository.GetAllIncludeAsync(cancellationToken));
}
