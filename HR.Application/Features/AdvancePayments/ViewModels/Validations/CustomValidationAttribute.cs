using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels.Validations;

/// <summary>
/// Kullanıcının seçimiş olduğu avans türü ve döviz birimine göre gireceği amount değerini 
/// validasyo işlemine tabi tutulması için yazıldı. ValidationResul döndüğü için controller'da 
/// ModelState.Isvalid  değeri If bloğu içerisinde değerlendirilip hata patlatılabilir. Fakat client-side
/// tarafında bir uyarı mesajı gelmemekte. 
/// </summary>

[AttributeUsage(AttributeTargets.Class)]
public class CustomValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var model = (AdvancePaymentCreateVM)validationContext.ObjectInstance;

        if (model.CurrencyType == CurrencyTypeVM.Dolar)
        {
            if (model.AdvanceType == AdvanceTypeVM.Personal && model.Amount > 15000)
            {
                return new ValidationResult("For Dolar currency and Personal advance type, the maximum amount is 15000.");
            }

            if (model.AdvanceType == AdvanceTypeVM.Corporate && model.Amount > 25000)
            {
                return new ValidationResult("For Dolar currency and Corporate advance type, the maximum amount is 25000.");
            }
        }

        // Add similar checks for Euro or other currencies if needed.

        return ValidationResult.Success;
    }


}