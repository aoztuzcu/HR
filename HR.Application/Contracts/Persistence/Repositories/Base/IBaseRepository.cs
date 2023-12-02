using HR.Domain.Base;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories.Base;

public interface IBaseRepository<T> where T : BaseEntity, new()
{
     Task<T> AddAsync(T entity, CancellationToken token);
     Task<T> UpdateAsync(T entity, CancellationToken token);
     Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token);
     Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken token);
}
