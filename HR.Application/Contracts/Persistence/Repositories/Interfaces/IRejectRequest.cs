using HR.Domain.Base;
using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IRejectRequest<T> where T : BaseEntity, new()
{
    Task<T> RejectByIdAsync(Guid id, CancellationToken token);
}
