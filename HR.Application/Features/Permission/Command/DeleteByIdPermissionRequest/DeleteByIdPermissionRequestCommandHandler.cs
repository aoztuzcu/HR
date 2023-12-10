using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;

public class DeleteByIdPermissionRequestCommandHandler : IRequestHandler<DeleteByIdPermissionRequestCommand, DeleteByIdPermissionRequestCommand>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public DeleteByIdPermissionRequestCommandHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository;
        this.mapper = mapper;
    }
    public async Task<DeleteByIdPermissionRequestCommand> Handle(DeleteByIdPermissionRequestCommand request, CancellationToken cancellationToken)
    {
        var permissionRequest = await permissionRequestRepository.DeleteByIdAsync(request.PermissionRequestId, cancellationToken);
        return mapper.Map<DeleteByIdPermissionRequestCommand>(permissionRequest);
    }
}
