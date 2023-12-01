using System.ComponentModel.DataAnnotations;

namespace HR.Domain.Enum;

public enum AdvanceType : byte
{
    [Display(Name ="Bireysel")]
    Personal = 1,
    [Display(Name = "Kurumsal")]
    Corporate
}