using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class PermissionRequestRepository : BaseRepository<PermissionRequest>, IPermissionRequestRepository
{
    public PermissionRequestRepository(HRContext context) : base(context)
    {
    }

    public async Task<Permissions> Find(Expression<Func<Permissions, bool>> expression)
    {
        return await context.Set<Permissions>().Where(expression).FirstOrDefaultAsync();
    }


    public async Task<IEnumerable<PermissionRequest>> GetAllByPersonIdAsync(Guid id, CancellationToken token)
    => await context.PermissionRequests.Include(x => x.PermissionType).Where(g => g.PersonnelId == id && g.IsActive==true).ToListAsync();//await base.GetAllAsync(g => g.PersonnelId == id, token);
}
