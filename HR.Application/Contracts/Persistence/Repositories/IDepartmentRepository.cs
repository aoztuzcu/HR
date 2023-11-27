using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IDepartmentRepository : IBaseRepository<Department>
{
    Task<Department> GetByIdAsync(Guid Id, CancellationToken token);
}
