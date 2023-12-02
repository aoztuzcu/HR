using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Repositories;

public class AdvancePaymentRepository : BaseRepository<AdvancePayment>, IAdvancePaymentRepository
{
    public AdvancePaymentRepository(HRContext context) : base(context) { }

    public async Task<IEnumerable<AdvancePayment>> GetAllByPersonIdAsync(Guid id, CancellationToken token)
        => await base.GetAllAsync(g => g.PersonId == id, token);

}
