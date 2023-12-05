using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.ViewModels
{
    public class PermissionRequestCreateVM
    {
        public Guid PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Days { get; set; }
        //public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
        //public DateTime ApprovedDate { get; set; }
        public Guid PermissionTypeId { get; set; }

        public IEnumerable<PermissionVM> PermissionList { get; set; }//kullanıcaya kayıtlı olan izin türlerini seçilebilir kılmak
        //public PermissionVM PermissionType { get; set; }

    }
}
