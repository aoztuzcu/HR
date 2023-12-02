using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public class AdvancePaymentCreateVM
{
    Guid PersonId { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }

    [Required(ErrorMessage = "Miktar boş geçilemez.")]
    [Range(typeof(decimal), "0.01", "50000.00", ErrorMessage = "Miktar için geçerli bir değer giriniz.")]
    public decimal Amount { get; set; }

    public CurrencyTypeVM CurrencyType { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;

    [Required(ErrorMessage = "Açıklama boş geçilemez.")]
    [MaxLength(100, ErrorMessage = "Açıklama alanına maksimum 100 karakter girişi yapabilirsiniz.")]
    public string Description { get; set; } = null!;
}
