using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.Command.ApprovePermissionRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.RejectPermissionRequest;

public class RejectPermissionRequestCommandHandler : IRequestHandler<RejectPermissionRequestCommand, RejectPermissionRequestCommand>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public RejectPermissionRequestCommandHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository;
        this.mapper = mapper;
    }

    public async Task<RejectPermissionRequestCommand> Handle(RejectPermissionRequestCommand request, CancellationToken cancellationToken)
    {
        var model = await permissionRequestRepository.RejectByIdAsync(request.PermissionRequestId, cancellationToken);
        return mapper.Map<RejectPermissionRequestCommand>(model);
    }
}
