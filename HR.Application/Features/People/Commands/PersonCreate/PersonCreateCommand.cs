using HR.Domain.Concrete.Identity;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Application.Features.People.ViewModels;

namespace HR.Application.Features.People.Commands.PersonCreate;

public class PersonCreateCommand : IRequest<PersonCreateCommand>
{
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public GenderVM Gender { get; set; }
    public decimal Salary { get; set; }
    public string Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Guid DepartmentId { get; set; }
    public string CompanyName { get; set; }
    public Guid CompanyId { get; set; }
    public Guid UserId { get; set; }
}
