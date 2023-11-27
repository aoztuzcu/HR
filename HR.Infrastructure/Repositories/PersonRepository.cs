using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HR.Persistence.Repositories;

public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(HRContext context) : base(context) { }

    public async Task<Person> GetByIdAsync(Guid Id, CancellationToken token)
        => await context.People.Include(x => x.Department).Include(y => y.Job).FirstOrDefaultAsync(f => f.Id == Id, token);
}
