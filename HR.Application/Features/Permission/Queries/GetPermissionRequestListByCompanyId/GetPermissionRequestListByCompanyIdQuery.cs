using HR.Application.Features.Permission.ViewModels;
using MediatR;

namespace HR.Application.Features.Permission.Queries.GetPermissionRequestListByCompanyId;

public class GetPermissionRequestListByCompanyIdQuery : IRequest<IEnumerable<PermissionRequestApproveListVM>>
{
    public Guid CompanyId { get; set; }
}
