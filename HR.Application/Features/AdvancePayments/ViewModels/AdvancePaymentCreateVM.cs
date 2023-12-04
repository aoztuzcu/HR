using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

// CustomValidationAttribute için eklenmiştir.
//[HR.Application.Features.AdvancePayments.ViewModels.Validations.CustomValidation]
public class AdvancePaymentCreateVM
{
    public Guid PersonnelId { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }

    [Required(ErrorMessage = "Miktar boş geçilemez.")]
    [Range(0, 50000.00, ErrorMessage = "Miktarı 50000'den küçük olmalıdır.")]
    public decimal Amount { get; set; }

    public CurrencyTypeVM CurrencyType { get; set; }

    [Required(ErrorMessage = "Açıklama boş geçilemez.")]
    [MinLength(5, ErrorMessage = "Açıklama alanına minimum 5 karakter giriş yapmalısınız.")]
    [MaxLength(100, ErrorMessage = "Açıklama alanına maksimum 100 karakter girişi yapabilirsiniz.")]
    public string Description { get; set; } = null!;
}
