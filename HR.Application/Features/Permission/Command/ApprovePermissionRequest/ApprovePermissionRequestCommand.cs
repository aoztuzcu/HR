using MediatR;

namespace HR.Application.Features.Permission.Command.ApprovePermissionRequest;

public class ApprovePermissionRequestCommand : IRequest<ApprovePermissionRequestCommand>
{
    public Guid PermissionRequestId { get; set; }
}
