using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Base;
using HR.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
{
    protected readonly HRContext context;

    public BaseRepository(HRContext context)
        => this.context = context;

    public async Task<T> AddAsync(T entity, CancellationToken token)
    {
        context.Entry(entity).State = EntityState.Added;
        await context.Set<T>().AddAsync(entity, token);
        await context.SaveChangesAsync(token);
        return entity;
    }

    public async Task<T> DeleteByIdAsync(Guid id, CancellationToken token)
    {
        var entity = await context.Set<T>().FirstOrDefaultAsync(f => f.Id == id);
        if (entity != null)
        {
            context.Entry(entity).State = EntityState.Modified;
            entity.IsActive = false;
            await context.SaveChangesAsync(token);
            return entity;
        }
        throw new KeyNotFoundException($"Entity with ID {id} not found.");
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken token)
        => await context.Set<T>().Where(expression).ToListAsync(token);

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token)
        => await context.Set<T>().FirstOrDefaultAsync(expression, token) ?? throw new Exception($"{nameof(T)} Data Not Found!");

    public async Task<T> UpdateAsync(T entity, CancellationToken token)
    {
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync(token);
        return entity;
    }
}
