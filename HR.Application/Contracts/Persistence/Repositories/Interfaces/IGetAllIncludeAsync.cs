using HR.Domain.Base;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IGetAllIncludeAsync<T> where T : BaseEntity, new()
{
    Task< IEnumerable<T>> GetAllIncludeAsync(CancellationToken cancellationToken);
}
