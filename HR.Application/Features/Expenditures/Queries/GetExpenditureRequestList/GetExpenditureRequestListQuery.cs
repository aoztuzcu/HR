using HR.Application.Features.Expenditures.ViewModels;
using MediatR;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureRequestList;

public class GetExpenditureRequestListQuery : IRequest<IEnumerable<ExpenditureApproveListVM>>
{
}
