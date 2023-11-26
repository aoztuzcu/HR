using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.ViewModels;

public class PersonUpdateVM
{
    public Guid Id { get; set; }
    public string Photo { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}
