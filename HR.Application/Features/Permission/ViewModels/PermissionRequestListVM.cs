using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.ViewModels
{
    public class PermissionRequestListVM
    {
        public List<PermissionRequestCreateVM> ApprovalWaitingList { get; set; }
        public List<PermissionRequestCreateVM> ApprovedList { get; set; }
        public List<PermissionRequestCreateVM> RejectedList { get; set; }
    }
}
