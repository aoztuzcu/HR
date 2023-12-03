using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.ViewModels
{
    public enum GenderVM : byte
    {
        [Display(Name = "Erkek")]
        Male,
        [Display(Name = "Kadın")]
        Female
    }
}
