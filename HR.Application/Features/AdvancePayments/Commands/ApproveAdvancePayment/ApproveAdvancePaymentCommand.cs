using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.ApproveAdvancePayment;

public class ApproveAdvancePaymentCommand : IRequest<ApproveAdvancePaymentCommand>
{
    public Guid AdvancePaymentId { get; set; }
}
