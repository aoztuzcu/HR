using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.ViewModels;

public class CompanyUpdateVM
{

    public Guid Id { get; set; }

    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Şirket ismi yalnızca harflerden oluşabilir!")]
    [MinLength(2, ErrorMessage = "Şirket ismi en az 2 harften oluşmalıdır!")]
    [Required(ErrorMessage = "Şirket ismi boş geçilemez!")]
    [Display(Name = "Ad ")]

    public string Name { get; set; }
    [Required(ErrorMessage = "Şirket tipi boş geçilemez!")]
    [Display(Name = "Ünvan ")]
    public string Type { get; set; }

    [RegularExpression(@"^0[0-9]{10}$", ErrorMessage = "Telefon numarası 0 ile başlamalı ve toplam 11 haneden oluşmalıdır")]
    [Required(ErrorMessage = "Telefon Numarası boş geçilemez!")]
    [Display(Name = "Telefon Numarası ")]

    public string PhoneNumber { get; set; }
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
    [Required(ErrorMessage = "E-posta adresi boş geçilemez!")]
    [Display(Name = "Mail Adresi ")]

    public string Email { get; set; }

    [Required(ErrorMessage = "Sözleşme başlangıç tarihi boş geçilemez!")]
    [Display(Name = "Sözleşme Başlangıç Tarihi ")]

    public DateTime ContractStartDate { get; set; }
    [Required(ErrorMessage = "Sözleşme bitiş tarihi boş geçilemez!")]
    [Display(Name = "Sözleşme Bitiş Tarihi ")]
    public DateTime ContractEndDate { get; set; }

    [RegularExpression(@"^\d{11}000\d{2}$", ErrorMessage = "MERSİS numarası 16 haneli olmalı ve son 5 hanesi '000XX' formatında olmalıdır.")]
    [Required(ErrorMessage = "Mersis Numarası boş geçilemez!")]
    [Display(Name = "Mersis Numarası")]

    public string MersisNo { get; set; }

    [VergiNoValidation("MersisNo", ErrorMessage = "Vergi numarası MERSIS numarasına uygun değildir.")]
    [Required(ErrorMessage = "Vergi Numarası boş geçilemez!")]
    [MaxLength(10, ErrorMessage = "Vergi Numarası 10 rakamdan oluşmalıdır!")]
    [Display(Name = "Vergi Numarası ")]

    public string TaxNo { get; set; }

    [Required(ErrorMessage = "Vergi Dairesi boş geçilemez!")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Uygun formatta giriniz!")]
    [Display(Name = "Vergi Dairesi ")]

    public string TaxOffice { get; set; }

    public string LogoUrl { get; set; }
    public IFormFile? Logo { get; set; }
    [Required(ErrorMessage = "Şirket adresi boş geçilemez!")]
    [Display(Name = "Adres ")]

    public string Address { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "En az 1 çalışan olmalıdır.")]
    [Required(ErrorMessage = "Çalışan sayısı boş geçilemez!")]
    [Display(Name = "Çalışan Sayısı ")]

    public int EmployeesCount { get; set; }

    [Required(ErrorMessage = "Kuruluş yılı boş geçilemez!")]
    [Display(Name = "Kuruluş Yılı ")]
    [Range(1800,3000,ErrorMessage ="Uygun bir kuruluş yılı giriniz.")]
    public int EstablishmentYear { get; set; }


}

