using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IAdvancePaymentRepository : IBaseRepository<AdvancePayment>
{
    Task<IEnumerable<AdvancePayment>> GetAllByNameAsync(Guid id, CancellationToken token);
}
