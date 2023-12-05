using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using System.Linq.Expressions;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IPersonnelRepository : IBaseRepository<Personnel>
{
    Task<Personnel> GetByIdAsync(Guid Id, CancellationToken token);
    Task<Personnel> UpdateAsyncByPerson(Personnel personnel, CancellationToken token);

}
