using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class ExpenditureTypeRepository : BaseRepository<ExpenditureType>, IExpenditureTypeRepository
{
    public ExpenditureTypeRepository(HRContext context) : base(context)
    {
    }

    //public async Task<IEnumerable<ExpenditureType>> GetAllAsync(CancellationToken token)
    //{
    //    return await context.ExpenditureTypes.ToListAsync(token);
    //}
}
