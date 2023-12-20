using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Expenditures.ViewModels;
using MediatR;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureRequestListByCompanyId;

public class GetExpenditureRequestListByCompanyIdQueryHandler : IRequestHandler<GetExpenditureRequestListByCompanyIdQuery, IEnumerable<ExpenditureApproveListVM>>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public GetExpenditureRequestListByCompanyIdQueryHandler(IExpenditureRepository expenditureRepository, IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<ExpenditureApproveListVM>> Handle(GetExpenditureRequestListByCompanyIdQuery request, CancellationToken cancellationToken)
         => mapper.Map<IEnumerable<ExpenditureApproveListVM>>(await expenditureRepository.GetAllByCompanyIdIncludeAsync(request.CompanyId, cancellationToken));
}
