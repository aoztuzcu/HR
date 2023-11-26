using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Department: BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<Person> Persons { get; set; }
}
