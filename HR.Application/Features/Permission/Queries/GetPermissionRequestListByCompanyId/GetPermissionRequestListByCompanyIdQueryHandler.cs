using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.ViewModels;
using MediatR;

namespace HR.Application.Features.Permission.Queries.GetPermissionRequestListByCompanyId;

public class GetPermissionRequestListByCompanyIdQueryHandler : IRequestHandler<GetPermissionRequestListByCompanyIdQuery, IEnumerable<PermissionRequestApproveListVM>>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public GetPermissionRequestListByCompanyIdQueryHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<PermissionRequestApproveListVM>> Handle(GetPermissionRequestListByCompanyIdQuery request, CancellationToken cancellationToken)
        => mapper.Map<IEnumerable<PermissionRequestApproveListVM>>(await permissionRequestRepository.GetAllByCompanyIdIncludeAsync(request.CompanyId, cancellationToken));

}
