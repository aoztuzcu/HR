using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HR.Application.Features.EnumViewModels;

public enum ApprovalStatusVM:byte
{
    [Display(Name = "Onay Bekliyor")]
    ApprovalWaiting = 1,
    [Display(Name = "Onaylandı")]
    Approved,
    [Display(Name = "Reddedildi")]
    Rejected
}
