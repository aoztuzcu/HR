using HR.Application.Features.Login.Validations;
using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.Login;

public class UserPasswordUpdateVM
{
    [Required(ErrorMessage = "Mevcut Şifre boş bırakılamaz.")]
    public string CurrentPassword { get; set; } = null!;

    [Required(ErrorMessage = "Yeni Şifre boş bırakılamaz.")]
    [StringLength(100, ErrorMessage = "Şifre en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
    [CustomCompare("CurrentPassword", "Mevcut şifrenizi kullanamazsınız.")]
    public string NewPassword { get; set; } = null!;

    [Required(ErrorMessage = "Yeni Şifre Tekrarı boş bırakılamaz.")]
    [Compare("NewPassword", ErrorMessage = "Yeni şifre ile onay şifresi eşleşmiyor.")]
    public string NewPasswordConfirm { get; set; } = null!;
}
