using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Contracts.Persistence.Repositories.Interfaces;
using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IAdvancePaymentRepository : IBaseRepository<AdvancePayment>
                                           , IApproveRequest<AdvancePayment>
                                           , IRejectRequest<AdvancePayment>
                                           , IGetAllByCompanyIdIncludeAsync<AdvancePayment>
{
    Task<IEnumerable<AdvancePayment>> GetAllByPersonIdAsync(Guid id, CancellationToken token);
}
