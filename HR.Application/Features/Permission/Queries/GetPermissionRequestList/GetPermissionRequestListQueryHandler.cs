using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries.GetPermissionRequestList;

public class GetPermissionRequestListQueryHandler : IRequestHandler<GetPermissionRequestListQuery, IEnumerable<PermissionRequestApproveListVM>>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public GetPermissionRequestListQueryHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<PermissionRequestApproveListVM>> Handle(GetPermissionRequestListQuery request, CancellationToken cancellationToken)
        => mapper.Map<IEnumerable<PermissionRequestApproveListVM>>(await permissionRequestRepository.GetAllIncludeAsync(cancellationToken));

}
