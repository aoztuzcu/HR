using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class ExpenditureRepository : BaseRepository<Expenditure>, IExpenditureRepository
{
    public ExpenditureRepository(HRContext context) : base(context) { }

    public async Task<Expenditure> ApproveByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.Expenditures.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Approved;
        model.ApprovedDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return model;
    }

    public async Task<IEnumerable<Expenditure>> GetAllByPersonIdAsync(Guid personId, CancellationToken token)
        => await context.Expenditures.Include(x => x.ExpenditureType).Where(x => x.PersonnelId == personId && x.IsActive == true).ToListAsync();

    public async Task<IEnumerable<Expenditure>> GetAllIncludeAsync(CancellationToken cancellationToken)
        => await context.Expenditures.Include(x => x.ExpenditureType).Include(y => y.Personnel).Where(w => w.IsActive == true).ToListAsync();

    public async Task<Expenditure> RejectByIdAsync(Guid id, CancellationToken token)
    {
        var model = await context.Expenditures.FirstOrDefaultAsync(f => f.Id == id) ?? throw new ArgumentNullException("Entity not found.");
        model.ApprovalStatus = ApprovalStatus.Rejected;
        model.ApprovedDate = DateTime.Now;
        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return model;
    }
}
