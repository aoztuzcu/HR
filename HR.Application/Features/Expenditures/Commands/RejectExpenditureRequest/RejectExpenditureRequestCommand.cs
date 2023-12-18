using MediatR;

namespace HR.Application.Features.Expenditures.Commands.RejectExpenditureRequest;

public class RejectExpenditureRequestCommand : IRequest<RejectExpenditureRequestCommand>
{
    public Guid ExpenditureId { get; set; }
}
