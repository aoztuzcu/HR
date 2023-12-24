using HR.Domain.Concrete.Identity;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using HR.Application.Features.Jobs.ViewModels;
using HR.Application.Features.Departments.ViewModels;
using System.ComponentModel.DataAnnotations;
using HR.Application.Features.People.ViewModels.Validations;

namespace HR.Application.Features.People.ViewModels;

public class PersonUpdateByManagerVM
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "TC Kimlik Numarası zorunludur.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "TC Kimlik Numarası sadece rakam içermelidir.")]
    [CustomIdentityNumberValidation]
    public string IdentityNumber { get; set; }

    [Required(ErrorMessage = "Ad zorunludur.")]
    [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olmalıdır.")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Ad alanına sadece karakter girişi yapılabilir.")]
    public string Name { get; set; }

    [StringLength(50, ErrorMessage = "İkinci Ad en fazla 50 karakter olmalıdır.")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "İkinci Ad alanına sadece karakter girişi yapılabilir.")]
    public string? SecondName { get; set; }

    [Required(ErrorMessage = "Soyad zorunludur.")]
    [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olmalıdır.")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "Soyad alanına sadece karakter girişi yapılabilir.")]
    public string Surname { get; set; }

    [StringLength(50, ErrorMessage = "İkinci Soyad en fazla 50 karakter olmalıdır.")]
    [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$", ErrorMessage = "İkinci Soyad alanına sadece karakter girişi yapılabilir.")]
    public string? SecondSurname { get; set; }
    public string Email { get; set; }

    [Required(ErrorMessage = "Adres zorunludur.")]
    [MaxLength(200, ErrorMessage = "Adres alanı en fazla {1} karakter olmalıdır.")]
    [MinLength(20, ErrorMessage = "Adres alanı en az {1} karakter olmalıdır.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Telefon Numarası zorunludur.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
    public string PhoneNumber { get; set; }

    public string? Photo { get; set; }

    [Required(ErrorMessage = "Fotoğraf zorunludur.")]
    [AllowedFileExtensions(new string[] { ".png", ".jpeg", ".jpg" })]
    public IFormFile? PhotoFile { get; set; }

    [Required(ErrorMessage = "Doğum Tarihi zorunludur.")]
    [DataType(DataType.Date)]
    [Display(Name = "Doğum Tarihi")]
    [MinimumAge(18, ErrorMessage = "Kişi en az 18 yaşında olmalıdır.")]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Doğum Yeri zorunludur.")]
    public string PlaceofBirth { get; set; }

    [Required(ErrorMessage = "İşe Giriş Tarihi zorunludur.")]
    [DataType(DataType.Date)]
    public DateTime HireDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime? FireDate { get; set; }

    [Required(ErrorMessage = "Meslek zorunludur.")]
    public Guid JobId { get; set; }

    [Required(ErrorMessage = "Departman zorunludur.")]
    public Guid DepartmentId { get; set; }

    [Required(ErrorMessage = "Şirket Adı zorunludur.")]
    public string CompanyName { get; set; }
    public Guid CompanyId { get; set; }

    [Required(ErrorMessage = "Maaş zorunludur.")]
    [Range(11402.32, double.MaxValue, ErrorMessage = "Maaş alanına minimum asgari ücret miktarını girmelisiniz.")]
    public decimal Salary { get; set; }

    public Guid UserId { get; set; }

    [Required(ErrorMessage = "Cinsiyet zorunludur.")]
    public Gender Gender { get; set; }


    // Kullanıcının seçerek değiştireceği property'ler
    public IEnumerable<JobVM>? Jobs { get; set; }
    public IEnumerable<DepartmentVM>? Departments { get; set; }
}
