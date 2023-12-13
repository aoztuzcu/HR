using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.People.ViewModels;

public class PersonCreateVM
{
    [Required(ErrorMessage = "TC Kimlik Numarası zorunludur.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "TC Kimlik Numarası sadece rakam içermelidir.")]
    public string IdentityNumber { get; set; }

    [Required(ErrorMessage = "Ad zorunludur.")]
    [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olmalıdır.")]
    public string Name { get; set; }

    [StringLength(50, ErrorMessage = "İkinci Ad en fazla 50 karakter olmalıdır.")]
    public string? SecondName { get; set; }

    [Required(ErrorMessage = "Soyad zorunludur.")]
    [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olmalıdır.")]
    public string Surname { get; set; }

    [StringLength(50, ErrorMessage = "İkinci Soyad en fazla 50 karakter olmalıdır.")]
    public string? SecondSurname { get; set; }

    [Required(ErrorMessage = "Adres zorunludur.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Telefon Numarası zorunludur.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Cinsiyet zorunludur.")]
    public GenderVM Gender { get; set; }

    [Required(ErrorMessage = "Maaş zorunludur.")]
    [Range(0, double.MaxValue, ErrorMessage = "Geçerli bir maaş giriniz.")]
    public decimal Salary { get; set; }

    [Required(ErrorMessage = "Fotoğraf zorunludur.")]
    public IFormFile Photo { get; set; }

    [Required(ErrorMessage = "Doğum Tarihi zorunludur.")]
    [DataType(DataType.Date)]
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

    public IEnumerable<JobVM> Jobs { get; set; }

    [Required(ErrorMessage = "Departman zorunludur.")]
    public Guid DepartmentId { get; set; }

    public IEnumerable<DepartmentVM> Departments { get; set; }

    [Required(ErrorMessage = "Şirket Adı zorunludur.")]
    public string CompanyName { get; set; }

    public Guid UserId { get; set; }
}