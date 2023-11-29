using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPersonRepository : IBaseRepository<Person>
{
    Task<Person> GetByIdAsync(Guid Id, CancellationToken token);
    Task<Person> UpdateAsyncByPerson(Person entity, CancellationToken token);
}
