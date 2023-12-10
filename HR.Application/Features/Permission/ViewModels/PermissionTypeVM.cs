using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.ViewModels;

public class PermissionTypeVM
{
    public Guid Id { get; set; }

    [Display(Name = "İzin Türü")]
    public string Name { get; set; }
}
