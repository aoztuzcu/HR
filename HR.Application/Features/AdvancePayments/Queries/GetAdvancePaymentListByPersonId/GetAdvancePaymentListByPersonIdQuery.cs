using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;

public class GetAdvancePaymentListByPersonIdQuery : IRequest<IEnumerable<AdvancePaymentVM>>
{
    public Guid PersonId { get; set; }
}
