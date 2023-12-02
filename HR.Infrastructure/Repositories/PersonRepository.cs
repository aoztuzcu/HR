using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR.Persistence.Repositories;

public class PersonRepository :IPersonRepository
{
    protected readonly HRContext context;

    public PersonRepository(HRContext context)
        => this.context = context;


    public async Task<User> GetAsync(Expression<Func<User, bool>> expression, CancellationToken token)
    {
        return await context.Set<User>().FirstOrDefaultAsync(expression, token) ?? throw new Exception($"{nameof(User)} Data Not Found!");
    }

    public async Task<User> GetByIdAsync(Guid Id, CancellationToken token)
        => await context.Set<User>().Include(x => x.Department).Include(y => y.Job).FirstOrDefaultAsync(f => f.Id == Id, token);


    public async Task<User> UpdateAsyncByPerson(User entity, CancellationToken token)
    {
        var model = await context.Set<User>().FirstOrDefaultAsync(f => f.Id == entity.Id) ?? throw new ArgumentNullException("Entity not found.");
        model.Address = entity.Address;
        model.PhoneNumber = entity.PhoneNumber;

        if (entity.Photo is not null)
            model.Photo = entity.Photo;

        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync(token);
        return model;
    }
}
