using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByCompanyId;

public class GetAdvancePaymentListByCompanyIdQueryHandler : IRequestHandler<GetAdvancePaymentListByCompanyIdQuery, IEnumerable<AdvancePaymentApproveListVM>>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public GetAdvancePaymentListByCompanyIdQueryHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<AdvancePaymentApproveListVM>> Handle(GetAdvancePaymentListByCompanyIdQuery request, CancellationToken cancellationToken)
        => mapper.Map<IEnumerable<AdvancePaymentApproveListVM>>(await advancePaymentRepository.GetAllByCompanyIdIncludeAsync(request.CompanyId, cancellationToken));

}
