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

public class PermissionTypeRepository : BaseRepository<Permissions>, IPermissionTypeRepository
{
    public PermissionTypeRepository(HRContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Permissions>> GetAllAsyncByFemale(CancellationToken cancellationToken)
    => await context.Set<Permissions>().Where(x => x.Name != "Babalık İzni").ToListAsync(cancellationToken);

    public async Task<IEnumerable<Permissions>> GetAllAsyncByMale(CancellationToken cancellationToken)
    => await context.Set<Permissions>().Where(x => x.Name != "Doğum İzni").ToListAsync(cancellationToken);
}
