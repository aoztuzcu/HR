using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.ViewModels;

public class CompanyCreateVM
{
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Şirket ismi yalnızca harflerden oluşabilir!")]
    [MinLength(2, ErrorMessage ="Şirket ismi en az 2 harften oluşmalıdır!")]
    [Required(ErrorMessage ="Şirket ismi boş geçilemez!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Şirket tipi boş geçilemez!")]

    public string Type { get; set; }
    [RegularExpression(@"^0[0-9]{10}$", ErrorMessage = "Telefon numarası 0 ile başlamalı ve toplam 11 haneden oluşmalıdır")]
    [Required(ErrorMessage = "Telefon Numarası boş geçilemez!")]

    public string PhoneNumber { get; set; }
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
    [Required(ErrorMessage = "E-posta adresi boş geçilemez!")]

    public string Email { get; set; }
    public DateTime ContractStartDate { get; set; }
    public DateTime ContractEndDate { get; set; }

    [RegularExpression(@"^\d{11}000\d{2}$", ErrorMessage = "MERSİS numarası 16 haneli olmalı ve son 5 hanesi '000XX' formatında olmalıdır.")]
    [Required(ErrorMessage = "Mersis Numarası boş geçilemez!")]
    public string MersisNo { get; set; }

    [VergiNoValidation("MersisNo", ErrorMessage = "Vergi numarası MERSIS numarasına uygun değildir.")]
    [Required(ErrorMessage = "Vergi Numarası boş geçilemez!")]
    public string TaxNo { get; set; }
    [Required(ErrorMessage = "Vergi Dairesi boş geçilemez!")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Uygun formatta giriniz!")]
    public string TaxOffice { get; set; }
    public string LogoUrl { get; set; }
    public IFormFile Logo { get; set; }
    [MinLength(10, ErrorMessage ="Adres en az 10 karakterden oluşmalıdır.")]
    [Required(ErrorMessage = "Şirket adresi boş geçilemez!")]
    public string Address { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "En az 1 çalışan olmalıdır.")]
    [Required(ErrorMessage = "Çalışan sayısı boş geçilemez!")]
    public int EmployeesCount { get; set; }
    public int EstablishmentYear { get; set; }

}

//deneme sonra kaldırılabilir 
public class VergiNoValidationAttribute : ValidationAttribute
{
    private readonly string _mersisNoPropertyName;

    public VergiNoValidationAttribute(string mersisNoPropertyName)
    {
        _mersisNoPropertyName = mersisNoPropertyName;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var mersisNoProperty = validationContext.ObjectType.GetProperty(_mersisNoPropertyName);
        var mersisNoValue = (string)mersisNoProperty.GetValue(validationContext.ObjectInstance, null);

        if (IsVergiNoValid(value as string, mersisNoValue))
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(ErrorMessage ?? "Vergi numarası MERSIS numarasına uygun değildir.");
        }
    }

    private bool IsVergiNoValid(string vergiNo, string mersisNo)
    {
        if (string.IsNullOrEmpty(vergiNo) || string.IsNullOrEmpty(mersisNo) || mersisNo.Length < 10)
        {
            return false;
        }

        // MERSIS numarasının 2. hanesinden 10. hanesine kadar olan kısmı al
        var expectedVergiNoPart = mersisNo.Substring(1, 10);

        // Kontrol et
        return string.Equals(vergiNo, expectedVergiNoPart);
    }
}