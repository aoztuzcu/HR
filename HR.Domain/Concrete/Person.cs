using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HR.Domain.Concrete;

public class Person : BaseEntity
{
    //public Person()
    //{
    //    Mail = CreateMail(Name, Surname);
    //}
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string? SecondSurname { get; set; }

    //private string? mail;
    public string? Mail { get; set; }

    //public string? Mail
    //{
    //    get
    //    {
    //        return $"{Name.Trim().ToLower()}.{Surname.Trim().ToLower()}@bilgeadam.com"; ;
    //    }
    //    set { }
    //}
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
    public string Photo { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceofBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? FireDate { get; set; }
    public Guid JobId { get; set; }
    public Job? Job { get; set; }
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
    public string CompanyName { get; set; }
    private string CreateMail(string name, string surname)
    {
        return $"{name.Trim().ToLower()}.{surname.Trim().ToLower()}@bilgeadam.com";
    }
}


