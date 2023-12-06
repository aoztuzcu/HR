using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.ViewModels;

public class PermissionTypeVM
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public float? Days { get; set; }
    public IEnumerable<PermissionRequestCreateVM>? PermissionRequests { get; set; }
}
