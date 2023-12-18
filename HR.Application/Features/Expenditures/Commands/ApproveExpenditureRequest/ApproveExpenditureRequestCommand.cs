using MediatR;

namespace HR.Application.Features.Expenditures.Commands.ApproveExpenditureRequest;

public class ApproveExpenditureRequestCommand : IRequest<ApproveExpenditureRequestCommand>
{
    public Guid ExpenditureId { get; set; }
}
