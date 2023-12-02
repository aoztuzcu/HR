using HR.Domain.Base;
using HR.Domain.Concrete.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Department: BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<User.User>? People { get; set; } 
}
