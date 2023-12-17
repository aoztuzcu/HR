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

    public async Task<PermissionRequest> ApproveByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.PermissionRequests.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Approved;
        model.ApprovedDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync(token);
        return model;
    }

    public async Task<Permissions> Find(Expression<Func<Permissions, bool>> expression)
    {
        return await context.Set<Permissions>().Where(expression).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<PermissionRequest>> GetAllByPersonIdAsync(Guid id, CancellationToken token)
    => await context.PermissionRequests.Include(x => x.PermissionType).Where(g => g.PersonnelId == id && g.IsActive == true).ToListAsync();//await base.GetAllAsync(g => g.PersonnelId == id, token);

    public async Task<IEnumerable<PermissionRequest>> GetAllIncludeAsync(CancellationToken cancellationToken)
        => await context.PermissionRequests.Include(x => x.Personnel).Include(y => y.PermissionType).Where(w=>w.IsActive).ToListAsync(cancellationToken);

    public async Task<PermissionRequest> RejectByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.PermissionRequests.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Rejected;
        model.ApprovedDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync(token);
        return model;
    }
}
