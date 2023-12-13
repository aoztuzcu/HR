using HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Commands.DeleteByIdExpenditure;

public class DeleteByIdExpenditureCommand: IRequest<DeleteByIdExpenditureCommand>
{
    public Guid ExpenditureId { get; set; }
}
