using HR.Domain.Base;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IGetAllByCompanyIdIncludeAsync<T> where T : BaseEntity, new()
{
    //Task<IEnumerable<T>> GetAllIncludeAsync(CancellationToken cancellationToken);
    Task<IEnumerable<T>> GetAllByCompanyIdIncludeAsync(Guid companyId, CancellationToken cancellationToken);
}
