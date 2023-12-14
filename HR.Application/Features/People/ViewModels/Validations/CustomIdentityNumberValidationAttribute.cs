using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HR.Application.Features.People.ViewModels.Validations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class CustomIdentityNumberValidationAttribute : ValidationAttribute
{
    private const int IdentityNumberLength = 11;

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return new ValidationResult("TC kimlik numarası boş geçilemez");
        }

        string identityNumberStr = value.ToString();

        if (identityNumberStr.Length != IdentityNumberLength)
        {
            return new ValidationResult("TC kimlik numarası 11 hane olmalıdır.");
        }

        string[] wrongIdList = { "11111111110",
                                 "22222222220",
                                 "33333333330",
                                 "44444444440",
                                 "55555555550",
                                 "66666666660",
                                 "77777777770",
                                 "88888888880",
                                 "99999999990"};

        if (wrongIdList.Contains(identityNumberStr))
        {
            return new ValidationResult("TC kimlik numarası hatalıdır. hatalı kimlik no listesi içerisindedir.");
        }

        if (identityNumberStr[0] == '0')
        {
            return new ValidationResult("TC kimlik numarasının ilk hanesi sıfır olamaz.");
        }

        if (!long.TryParse(identityNumberStr, out long identityNumber))
        {
            return new ValidationResult("Hatalı değer girişi yaptınız. Kontrol ediniz.");
        }

        int oddIndexSum = identityNumberStr
            .Where((c, index) => index % 2 == 0 && index < IdentityNumberLength - 1)
            .Sum(c => int.Parse(c.ToString()));

        int evenIndexSum = identityNumberStr
            .Where((c, index) => index % 2 == 1 && index < IdentityNumberLength - 2)
            .Sum(c => int.Parse(c.ToString()));

        int tenthCharacter = Math.Abs(((7 * oddIndexSum) - evenIndexSum) % 10);

        if (tenthCharacter != int.Parse(identityNumberStr[9].ToString()))
        {
            return new ValidationResult("Girilen TC kimlik numarası hatalıdır. 10. karakter hatası");
        }

        int eleventhCharacter = Math.Abs((oddIndexSum + evenIndexSum + tenthCharacter) % 10);

        if (eleventhCharacter != int.Parse(identityNumberStr[10].ToString()))
        {
            return new ValidationResult("Girilen TC kimlik numarası hatalıdır. 11. karakter hatası");
        }

        return ValidationResult.Success;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
    }

    #region OldCode
    //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //{

    //    if (value == null)
    //    {
    //        return new ValidationResult("TC kimlik numarası boş geçilemez");

    //    }

    //    string identityNumberStr = value.ToString();

    //    if (string.IsNullOrEmpty(identityNumberStr))
    //    {
    //        return new ValidationResult("TC kimlik numarası boş geçilemez");
    //    }


    //    if (!int.TryParse(identityNumberStr, out int identityNumber))
    //    {
    //        return new ValidationResult("Hatalı değer girişi yaptınız. Kontrol ediniz.");
    //    }

    //    if (identityNumberStr.Length != 11)
    //    {
    //        return new ValidationResult("TC kimlik numarası 11 hane olmalıdır.");
    //    }

    //    string[] wrongIdList = { "11111111110",
    //                             "22222222220",
    //                             "33333333330",
    //                             "44444444440",
    //                             "55555555550",
    //                             "66666666660",
    //                             "77777777770",
    //                             "88888888880",
    //                             "99999999990"};

    //    if (wrongIdList.Contains(identityNumberStr))
    //    {
    //        return new ValidationResult("TC kimlik numarası hatalıdır");

    //    }

    //    if (identityNumberStr[0] == '0')
    //    {
    //        return new ValidationResult("TC kimlik numarasının ilk hanesi sıfır olamaz.");
    //    }

    //    int oddIndexSum = int.Parse(identityNumberStr[0].ToString()) +
    //                      int.Parse(identityNumberStr[2].ToString()) +
    //                      int.Parse(identityNumberStr[4].ToString()) +
    //                      int.Parse(identityNumberStr[6].ToString()) +
    //                      int.Parse(identityNumberStr[8].ToString());

    //    int evenIndexSum = int.Parse(identityNumberStr[1].ToString()) +
    //                       int.Parse(identityNumberStr[3].ToString()) +
    //                       int.Parse(identityNumberStr[5].ToString()) +
    //                       int.Parse(identityNumberStr[7].ToString());
    //    int tenthCharacter = ((7 * oddIndexSum) - evenIndexSum) % 10;

    //    if (tenthCharacter != int.Parse(identityNumberStr[9].ToString()))
    //    {
    //        return new ValidationResult("Girilen TC kimlik numamarası hatalıdır.");

    //    }

    //    int eleventhCharacter = (oddIndexSum + evenIndexSum + tenthCharacter) % 10;

    //    if (eleventhCharacter != int.Parse(identityNumberStr[10].ToString()))
    //    {
    //        return new ValidationResult("Girilen TC kimlik numamarası hatalıdır.");

    //    }
    //    return ValidationResult.Success;
    //}

    //public override string FormatErrorMessage(string name)
    //{
    //    return String.Format(CultureInfo.CurrentCulture,
    //      ErrorMessageString, name);
    //} 
    #endregion
}
