using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.RejectAdvancePayment;

public class RejectAdvancePaymentCommand : IRequest<RejectAdvancePaymentCommand>
{
    public Guid AdvancePaymentId { get; set; }
}
