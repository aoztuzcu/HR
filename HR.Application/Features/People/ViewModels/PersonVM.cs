using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.ViewModels;

public class PersonVM
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string EMail { get; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Photo { get; set; }
    public Guid JobId { get; set; }
    public Guid DepartmentId { get; set; }
    public DepartmentVM Department { get; set; }
    public JobVM Job { get; set; }
    public GenderVM Gender { get; set; }
}
