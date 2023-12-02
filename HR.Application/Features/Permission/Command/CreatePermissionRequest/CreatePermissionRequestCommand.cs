using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest
{
    public class CreatePermissionRequestCommand : IRequest<CreatePermissionRequestCommand>
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Person? Person { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public float Days { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.ApprovalWaiting;
        public DateTime ApprovedDate { get; set; }
        public Guid PermissionTypeId { get; set; }
        
    }
}
