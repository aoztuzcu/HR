using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByCompanyId;

public class GetAdvancePaymentListByCompanyIdQuery : IRequest<IEnumerable<AdvancePaymentApproveListVM>>
{
    public Guid CompanyId { get; set; }
}
