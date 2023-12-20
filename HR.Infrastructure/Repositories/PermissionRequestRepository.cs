using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR.Persistence.Repositories;

public class PermissionRequestRepository : BaseRepository<PermissionRequest>, IPermissionRequestRepository
{
    public PermissionRequestRepository(HRContext context) : base(context) { }

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

    public async Task<IEnumerable<PermissionRequest>> GetAllByCompanyIdIncludeAsync(Guid companyId, CancellationToken cancellationToken)
    {
        var list = await context.PermissionRequests.Include(x => x.Personnel).Include(y => y.PermissionType).Where(w => w.IsActive == true && w.Personnel.CompanyId == companyId).ToListAsync(cancellationToken);
        return list;

        #region Solution-Linq-Join
        //var result = await context.PermissionRequests.Include(x => x.PermissionType).Include(y => y.Personnel)
        //                                      .Join(context.Personnels, pr => pr.PersonnelId, p => p.Id, (pr, p) => new { pr, p })
        //                                      .Join(context.Users, p => p.p.UserId, u => u.Id, (p, u) => new { p, u })
        //                                      .Join(context.UserRoles, u => u.u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
        //                                      .Join(context.Roles, f => f.ur.RoleId, r => r.Id, (f, r) => new { f, r })
        //                                      .Where(w => w.r.NormalizedName == ("PERSONNEL") && w.f.u.p.p.CompanyId == companyId)
        //                                      .Select(joined => new PermissionRequest()
        //                                      {
        //                                          Id = joined.f.u.p.pr.Id,

        //                                          PersonnelId = joined.f.u.p.pr.Id,
        //                                          Personnel = joined.f.u.p.pr.Personnel,
        //                                          StartDate = joined.f.u.p.pr.StartDate,
        //                                          EndDate = joined.f.u.p.pr.EndDate,
        //                                          Days = joined.f.u.p.pr.Days,
        //                                          ApprovalStatus = joined.f.u.p.pr.ApprovalStatus,
        //                                          ApprovedDate = joined.f.u.p.pr.ApprovedDate,
        //                                          PermissionTypeId = joined.f.u.p.pr.PermissionTypeId,
        //                                          PermissionType = joined.f.u.p.pr.PermissionType,

        //                                          IsActive = joined.f.u.p.pr.IsActive,
        //                                          CreatedDate = joined.f.u.p.pr.CreatedDate,
        //                                          DeletedDate = joined.f.u.p.pr.DeletedDate,
        //                                          UpdatedDate = joined.f.u.p.pr.UpdatedDate
        //                                      })
        //                                      .ToListAsync(cancellationToken);
        //return result;
        #endregion
    }
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
