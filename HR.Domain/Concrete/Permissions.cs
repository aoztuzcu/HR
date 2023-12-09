using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Permissions:BaseEntity
{
    public string Name { get; set; }
    public float? Days { get; set; }
    public IEnumerable<PermissionRequest>? PermissionRequests { get; set; }
}
