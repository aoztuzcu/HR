using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Permission:BaseEntity
{
    public string Name { get; set; }
    public float? Days { get; set; }
}
