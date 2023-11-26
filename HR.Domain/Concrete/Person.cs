using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Person:BaseEntity
{
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }
    public string Mail
    {// Buraya bakılıcak
        get
        {
            return $"{Name}.{Surname}@bilgeadam.com";
        }
    }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
    public string Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Job Job { get; set; }
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
    public string CompanyName { get; set; }
}
