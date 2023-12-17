using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IRejectRequest
{
    Task<PermissionRequest> RejectByIdAsync(Guid id, CancellationToken token);
}
