using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Contracts.Persistence.Repositories.Interfaces;
using HR.Domain.Concrete;

namespace HR.Application.Contracts.Persistence.Repositories;

public interface IExpenditureRepository : IBaseRepository<Expenditure>,
                                          IApproveRequest<Expenditure>,
                                          IRejectRequest<Expenditure>,
                                          IGetAllIncludeAsync<Expenditure>
{
    Task<IEnumerable<Expenditure>> GetAllByPersonIdAsync(Guid personId, CancellationToken cancellationToken);
}
