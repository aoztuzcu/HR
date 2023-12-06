using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Contracts.Persistence.Repositories.Base;
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

public class PermissionTypeRepository : BaseRepository<PermissionType>, IPermissionTypeRepository
{
    public PermissionTypeRepository(HRContext context) : base(context)
    {
    }

    public async Task<IEnumerable<PermissionType>> GetAllAsync()
      => await context.Permissions.ToListAsync();
}
