using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;

public class GetPermissionRequestListByPersonIdQueryHandler : IRequestHandler<GetPermissionRequestListByPersonIdQuery, IEnumerable<PermissionRequestListVM>>
{
    private readonly IPermissionRequestRepository permissionRequestRepository;
    private readonly IMapper mapper;

    public GetPermissionRequestListByPersonIdQueryHandler(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    {
        this.permissionRequestRepository = permissionRequestRepository ?? throw new ArgumentNullException(nameof(permissionRequestRepository));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public Task<IEnumerable<PermissionRequestListVM>> Handle(GetPermissionRequestListByPersonIdQuery request, CancellationToken cancellationToken)
    {
        var list = await permissionRequestRepository.GetAllByPersonIdAsync(request.PersonnelId, cancellationToken);
        return mapper.Map<IEnumerable<AdvancePaymentListVM>>(list);
    }
}
