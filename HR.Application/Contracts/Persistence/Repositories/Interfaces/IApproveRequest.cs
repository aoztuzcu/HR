using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Repositories.Interfaces;

public interface IApproveRequest
{
    Task<PermissionRequest> ApproveByIdAsync(Guid id, CancellationToken token);

}
