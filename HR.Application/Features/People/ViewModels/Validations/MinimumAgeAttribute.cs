using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.ViewModels.Validations;

public class MinimumAgeAttribute : ValidationAttribute
{
    private readonly int _minimumAge;

    public MinimumAgeAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dogumTarihi)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dogumTarihi.Year;

            if (now.Month < dogumTarihi.Month || (now.Month == dogumTarihi.Month && now.Day < dogumTarihi.Day))
            {
                age--;
            }

            if (age < _minimumAge)
            {
                return new ValidationResult(GetErrorMessage(validationContext.DisplayName, _minimumAge));
            }
        }

        return ValidationResult.Success;
    }

    public string GetErrorMessage(string fieldName, int minimumAge)
    {
        return $"{fieldName} alanındaki kişinin en az {minimumAge} yaşında olması gerekmektedir.";
    }

}
