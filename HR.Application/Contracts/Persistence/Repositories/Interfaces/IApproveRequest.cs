using HR.Domain.Base;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IApproveRequest<T> where T : BaseEntity, new()
{
    Task<T> ApproveByIdAsync(Guid id, CancellationToken token);

}
