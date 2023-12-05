using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HR.Application.Features.Permission.ViewModels.PermissionRequestVM;

namespace HR.Application.Features.Permission.ViewModels
{
    public class PermissionVM
    {
        public string Name { get; set; }
        public float? Days { get; set; }

        public IEnumerable<PermissionRequestCreateVM>? PermissionRequests { get; set; }
    }
}
