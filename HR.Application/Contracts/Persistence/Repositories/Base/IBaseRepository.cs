using HR.Domain.Base;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories.Base;

public interface IBaseRepository<T> where T : BaseEntity, new()
{
     Task Update(T entity);
     Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token);
}
