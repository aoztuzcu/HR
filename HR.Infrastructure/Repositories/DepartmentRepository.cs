using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(HRContext context) : base(context) { }

    public async Task<Department> GetByIdAsync(Guid Id, CancellationToken token)
        => await base.GetAsync(g => g.Id == Id, token);

}
