using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;

public class GetAdvancePaymentListByPersonIdQuery : IRequest<IEnumerable<AdvancePaymentListVM>>
{
    public Guid PersonId { get; set; }
}
