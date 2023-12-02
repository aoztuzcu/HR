using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public enum AdvanceTypeVM : byte
{
    [Display(Name = "Bireysel")]
    Personal = 1,
    [Display(Name = "Kurumsal")]
    Corporate
}
