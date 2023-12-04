using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;

public class GetAdvancePaymentListByPersonIdQueryHandler : IRequestHandler<GetAdvancePaymentListByPersonIdQuery, IEnumerable<AdvancePaymentListVM>>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public GetAdvancePaymentListByPersonIdQueryHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository ?? throw new ArgumentNullException(nameof(advancePaymentRepository));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<AdvancePaymentListVM>> Handle(GetAdvancePaymentListByPersonIdQuery request, CancellationToken cancellationToken)
    {
        var list = await advancePaymentRepository.GetAllByPersonIdAsync(request.PersonnelId, cancellationToken);
        return mapper.Map<IEnumerable<AdvancePaymentListVM>>(list);
    }
}
