using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPermissionTypeRepository:IBaseRepository<Permissions>
{
    Task<IEnumerable<Permissions>> GetAllAsyncByFemale(CancellationToken cancellationToken);
    Task<IEnumerable<Permissions>> GetAllAsyncByMale(CancellationToken cancellationToken);
}
