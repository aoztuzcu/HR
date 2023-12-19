using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete.Identity;

public class User : IdentityUser<Guid>
{
    public string? IdentityNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Photo { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Address { get; set; }
    public IEnumerable<Personnel> Personnels { get; set; }
}
