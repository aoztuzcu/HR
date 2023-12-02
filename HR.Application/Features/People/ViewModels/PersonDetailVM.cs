using HR.Application.Exceptions;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace HR.Application.Features.People.ViewModels;
public class PersonDetailVM
{
    public Guid Id { get; set; }
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string EMail { get; set; }
    [Required(ErrorMessage = "Adres boş geçilemez.")]
    [MinLength(5, ErrorMessage ="Lütfen minimum 5 karakterden oluşan bir adres giriniz..")]
    public string Address { get; set; }
 
    [MinLength(10,ErrorMessage ="Lütfen 10 haneli bir telefon numarası giriniz. ")]
    [MaxLength(10, ErrorMessage = "Lütfen 10 haneli bir telefon numarası giriniz. ")]
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "Telefon numarası boş geçilemez.")]
    [RegularExpression(@"^(5\d{9})$", ErrorMessage = "Lütfen geçerli bir cep telefonu numarası giriniz.")]
    public string PhoneNumber { get; set; }
    [AllowedFileExtensions(new string[] {".png",".jpeg",".jpg"})]
    public string? Photo { get; set; }

    [AllowedFileExtensions(new string[] { ".png", ".jpeg", ".jpg" })]
    public IFormFile? PhotoFile { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Guid DepartmentId { get; set; }
    public DepartmentVM Department { get; set; }
    public JobVM Job { get; set; }
    public string CompanyName { get; set; }
    public decimal Salary { get; set; }
}
