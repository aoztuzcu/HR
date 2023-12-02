using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public enum ApprovalStatusVM : byte
{
    [Display(Name = "Onay Bekliyor")]
    ApprovalWaiting = 1,
    [Display(Name = "Onaylandı")]
    Approved,
    [Display(Name = "Reddedildi")]
    Rejected
}
