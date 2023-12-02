using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPersonRepository 
{
    Task<Person> GetAsync(Expression<Func<Person, bool>> expression, CancellationToken token);
    Task<Person> GetByIdAsync(Guid Id, CancellationToken token);
    Task<Person> UpdateAsyncByPerson(Person entity, CancellationToken token);
}
