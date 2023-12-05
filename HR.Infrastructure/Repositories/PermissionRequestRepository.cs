using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories
{
    public class PermissionRequestRepository : BaseRepository<PermissionRequest>,IPermissionRequestRepository
    {
        public PermissionRequestRepository(HRContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PermissionRequest>> GetAllByPersonIdAsync(Guid id, CancellationToken token)
        =>  await base.GetAllAsync(g => g.PersonnelId == id, token);

        public Task<Gender> GetByGender(Guid personId, CancellationToken token)
        {
            // dbsetten sonra sorgu atılacak
            throw new NotImplementedException();
        }

        public Task<PermissionRequest> GetByIdAsync(Guid Id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
