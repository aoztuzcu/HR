using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HR.Persistence.Repositories;

public class AdvancePaymentRepository : BaseRepository<AdvancePayment>, IAdvancePaymentRepository
{
    public AdvancePaymentRepository(HRContext context) : base(context) { }

    public async Task<AdvancePayment> ApproveByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.AdvancePayments.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Approved;
        model.ApprovalDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return model;
    }

    public async Task<IEnumerable<AdvancePayment>> GetAllByCompanyIdIncludeAsync(Guid companyId, CancellationToken cancellationToken)
    {
        {
            var list = await context.AdvancePayments.Include(y => y.Personnel).Where(w => w.IsActive == true && w.Personnel.CompanyId == companyId).ToListAsync();
            return list;

            #region Solution-Linq-Join
            //var result = await context.Expenditures.Include(x => x.ExpenditureType).Include(y => y.Personnel)
            //                                      .Join(context.Personnels, e => e.PersonnelId, p => p.Id, (e, p) => new { e, p })
            //                                      .Join(context.Users, p => p.p.UserId, u => u.Id, (p, u) => new { p, u })
            //                                      .Join(context.UserRoles, u => u.u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
            //                                      .Join(context.Roles, f => f.ur.RoleId, r => r.Id, (f, r) => new { f, r })
            //                                      .Where(w => w.r.NormalizedName == ("PERSONNEL") && w.f.u.p.p.CompanyId == companyId)
            //                                      .Select(joined => new Expenditure()
            //                                      {
            //                                          Id = joined.f.u.p.e.Id,
            //                                          Amount = joined.f.u.p.e.Amount,
            //                                          ApprovalStatus = joined.f.u.p.e.ApprovalStatus,
            //                                          ApprovedDate = joined.f.u.p.e.ApprovedDate,
            //                                          CurrencyType = joined.f.u.p.e.CurrencyType,
            //                                          CreatedDate = joined.f.u.p.e.CreatedDate,
            //                                          DeletedDate = joined.f.u.p.e.DeletedDate,
            //                                          Document = joined.f.u.p.e.Document,
            //                                          ExchangeAmount = joined.f.u.p.e.ExchangeAmount,
            //                                          ExpenditureTypeId = joined.f.u.p.e.ExpenditureTypeId,
            //                                          ExpenditureType = joined.f.u.p.e.ExpenditureType,
            //                                          IsActive = joined.f.u.p.e.IsActive,
            //                                          UpdatedDate = joined.f.u.p.e.UpdatedDate,
            //                                          PersonnelId = joined.f.u.p.p.Id,
            //                                          Personnel = joined.f.u.p.e.Personnel
            //                                          // Diğer alanları ekleyin
            //                                      })
            //                                      .ToListAsync(cancellationToken);
            //return result; 
            #endregion
        }
    }

    public async Task<IEnumerable<AdvancePayment>> GetAllByPersonIdAsync(Guid id, CancellationToken token)
        => await base.GetAllAsync(g => g.PersonnelId == id, token);

    public async Task<AdvancePayment> RejectByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.AdvancePayments.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Rejected;
        model.ApprovalDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return model;
    }
}
