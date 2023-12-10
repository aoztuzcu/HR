using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using Microsoft.AspNetCore.Http;

namespace HR.Application.Features.People.ViewModels;

public class PersonCreateVM
{
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public GenderVM Gender { get; set; }
    public decimal Salary { get; set; }
    public IFormFile Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public IEnumerable<JobVM> Jobs { get; set; }
    public Guid DepartmentId { get; set; }
    public IEnumerable<DepartmentVM> Departments { get; set; }
    public string CompanyName { get; set; }
    public Guid UserId { get; set; }
}
