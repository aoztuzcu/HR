using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;

namespace HR.Persistence.Repositories;

public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(HRContext context) : base(context) { }

    public async Task<Person> GetByIdAsync(Guid Id, CancellationToken token)
        => await base.GetAsync(g => g.Id == Id, token);
}
