using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Base;
using HR.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
{
    protected readonly HRContext context;

    public BaseRepository(HRContext context)
        => this.context = context;

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token)
        => await context.Set<T>().FirstOrDefaultAsync(expression, token) ?? throw new Exception($"{nameof(T)} Data Not Found!");

    public async Task Update(T entity)
    {
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
    }
}
