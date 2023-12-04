using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;

public class DeleteByIdAdvancePaymentCommand : IRequest<DeleteByIdAdvancePaymentCommand>
{
    public Guid AdvancePaymentId { get; set; }
}
