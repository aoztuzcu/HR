using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPermissionRequestRepository :IBaseRepository<PermissionRequest>
{
    Task<IEnumerable<PermissionRequest>> GetAllByPersonIdAsync(Guid id, CancellationToken token);
}
