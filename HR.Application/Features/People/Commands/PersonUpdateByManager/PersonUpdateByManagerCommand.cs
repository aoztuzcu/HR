using HR.Application.Exceptions;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using HR.Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace HR.Application.Features.People.Commands.PersonUpdateByManager;

public class PersonUpdateByManagerCommand : IRequest<PersonUpdateByManagerCommand>
{
    public Guid Id { get; set; }
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Guid DepartmentId { get; set; }
    public string CompanyName { get; set; }
    public Guid CompanyId { get; set; }
    public decimal Salary { get; set; }
    public Guid UserId { get; set; }
    public Gender Gender { get; set; }
}
