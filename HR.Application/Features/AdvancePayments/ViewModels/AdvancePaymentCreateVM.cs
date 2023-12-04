using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public class AdvancePaymentCreateVM
{
    public Guid PersonId { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }

    [Required(ErrorMessage = "Miktar boş geçilemez.")]
    //[Range(typeof(decimal), "0,01", "50000,00", ErrorMessage = "Miktar için geçerli bir değer giriniz.")]
    public decimal Amount { get; set; }

    public CurrencyTypeVM CurrencyType { get; set; }
   
    [Required(ErrorMessage = "Açıklama boş geçilemez.")]
    [MinLength(5,ErrorMessage ="Açıklama alanına minimum 5 karakter giriş yapmalısınız.")]
    [MaxLength(100, ErrorMessage = "Açıklama alanına maksimum 100 karakter girişi yapabilirsiniz.")]
    public string Description { get; set; } = null!;
}
