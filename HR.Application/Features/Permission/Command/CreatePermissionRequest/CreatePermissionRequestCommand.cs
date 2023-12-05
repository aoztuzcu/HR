using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Application.Features.Permission.ViewModels;
using HR.Application.Features.EnumViewModels;
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
        public Guid PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Days { get; set; }
        public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
        public DateTime ApprovedDate { get; set; }
        public Guid PermissionTypeId { get; set; }
       public PermissionTypeVM PermissionType { get; set; }
         
        
    }
}
