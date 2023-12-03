using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Repositories
{
    public interface IPermissionRequestRepository :IBaseRepository<PermissionRequest>
    {
        Task<PermissionRequest> GetByIdAsync(Guid Id, CancellationToken token);
       
        Task<Gender> GetByGender(Guid personId, CancellationToken token);
        
    }
}
