using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;
using HR.Domain.Concrete;
using MediatR;

namespace HR.Application.Features.Permission.Command.ApprovePermissionRequest;

public class ApprovePermissionRequestCommandHandler : IRequestHandler<ApprovePermissionRequestCommand, ApprovePermissionRequestCommand>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public ApprovePermissionRequestCommandHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository;
        this.mapper = mapper;
    }

    public async Task<ApprovePermissionRequestCommand> Handle(ApprovePermissionRequestCommand request, CancellationToken cancellationToken)
    {
        var model = await permissionRequestRepository.ApproveByIdAsync(request.PermissionRequestId, cancellationToken);
        return mapper.Map<ApprovePermissionRequestCommand>(model);
    }
}
