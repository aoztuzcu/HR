using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;

public class DeleteByIdPermissionRequestCommand: IRequest<DeleteByIdPermissionRequestCommand>
{
    public Guid PermissionRequestId { get; set; }
}
