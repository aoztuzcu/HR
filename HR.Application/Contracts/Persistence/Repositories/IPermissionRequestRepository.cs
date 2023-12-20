using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Contracts.Persistence.Repositories.Interfaces;
using HR.Domain.Concrete;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPermissionRequestRepository : IBaseRepository<PermissionRequest>
                                              , IApproveRequest<PermissionRequest>
                                              , IRejectRequest<PermissionRequest>
                                              , IGetAllByCompanyIdIncludeAsync<PermissionRequest>
{
    Task<IEnumerable<PermissionRequest>> GetAllByPersonIdAsync(Guid id, CancellationToken token);
    Task<Permissions> Find(Expression<Func<Permissions, bool>> expression);
}
