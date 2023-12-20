using HR.Application.Features.Expenditures.ViewModels;
using MediatR;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureRequestListByCompanyId;

public class GetExpenditureRequestListByCompanyIdQuery : IRequest<IEnumerable<ExpenditureApproveListVM>>
{            
    public Guid CompanyId { get; set; }
}
