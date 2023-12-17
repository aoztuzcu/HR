using MediatR;

namespace HR.Application.Features.Permission.Command.RejectPermissionRequest;

public class RejectPermissionRequestCommand : IRequest<RejectPermissionRequestCommand>
{
    public Guid PermissionRequestId { get; set; }
}
