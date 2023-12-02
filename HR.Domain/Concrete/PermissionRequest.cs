using HR.Domain.Base;
using HR.Domain.Concrete.User;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class PermissionRequest:BaseEntity
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public float Days { get; set; }
    public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.ApprovalWaiting;
    public DateTime ApprovedDate { get; set; }
    public Guid PermissionTypeId { get; set; }
    public Permission? PermissionType { get; set; }
}
