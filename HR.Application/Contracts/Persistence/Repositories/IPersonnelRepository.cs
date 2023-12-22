using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.Identity;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPersonnelRepository : IBaseRepository<Personnel>
{
    Task<Personnel> GetByIdAsync(Guid Id, CancellationToken token);
    Task<Personnel> UpdateAsyncByPerson(Personnel personnel, CancellationToken token);
    Task<IEnumerable<Personnel>> GetAllIncludeAsync();
    Task<IEnumerable<Personnel>> GetAllByCompanyIdIncludeAsync(Guid companyId);
    Task<IEnumerable<Personnel>> GetAllManagers();

}
