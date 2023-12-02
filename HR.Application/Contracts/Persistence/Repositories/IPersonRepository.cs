using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPersonRepository 
{
    Task<User> GetAsync(Expression<Func<User, bool>> expression, CancellationToken token);
    Task<User> GetByIdAsync(Guid Id, CancellationToken token);
    Task<User> UpdateAsyncByPerson(User entity, CancellationToken token);
}
