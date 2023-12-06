using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestCommandHandler : IRequestHandler<CreatePermissionRequestCommand, CreatePermissionRequestCommand>
{
    private readonly IPermissionRequestRepository repository;
    private readonly IPersonnelRepository personnelRepository;
    private readonly IMapper mapper;

    public CreatePermissionRequestCommandHandler(IPermissionRequestRepository repository, IMapper mapper, IPersonnelRepository personnelRepository)
    {
        this.repository = repository;
        this.mapper = mapper;
        this.personnelRepository = personnelRepository;
    }

    public async Task<CreatePermissionRequestCommand> Handle(CreatePermissionRequestCommand request, CancellationToken cancellationToken)
    {
        var permissionrequest = mapper.Map<PermissionRequest>(request);
        var result = await repository.AddAsync(permissionrequest, cancellationToken);
        return mapper.Map<CreatePermissionRequestCommand>(result);
    }   
}
