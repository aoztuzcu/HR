using HR.Application.Features.AdvancePayments.ViewModels.Validations;
using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public class AdvancePaymentCreateVM
{
    public Guid? PersonnelId { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }

    [Required(ErrorMessage = "Miktar boş geçilemez.")]
    [Range(0, 125000.00, ErrorMessage = "Miktar alanına 0 ile 125000 arasında değer yazabilirsiniz.")]
    [CustomAmountValidation]
    public decimal Amount { get; set; }

    public CurrencyTypeVM CurrencyType { get; set; }

    [Required(ErrorMessage = "Açıklama boş geçilemez.")]
    [MinLength(5, ErrorMessage = "Açıklama alanına minimum 5 karakter giriş yapmalısınız.")]
    [MaxLength(100, ErrorMessage = "Açıklama alanına maksimum 100 karakter girişi yapabilirsiniz.")]
    public string Description { get; set; } = null!;
}
