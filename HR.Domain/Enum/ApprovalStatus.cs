using System.ComponentModel.DataAnnotations;

namespace HR.Domain.Enum;

public enum ApprovalStatus : byte
{
    [Display(Name ="Onay Bekliyor")]
    ApprovalWaiting= 1,
    [Display(Name = "Onaylandı")]
    Approved,
    [Display(Name = "Reddedildi")]
    Rejected
}
