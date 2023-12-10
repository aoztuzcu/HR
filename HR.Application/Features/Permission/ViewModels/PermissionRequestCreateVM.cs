using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Application.Features.EnumViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.Application.Features.Permission.ViewModels;

public class PermissionRequestCreateVM
{
    public Guid PersonnelId { get; set; }
    [Required(ErrorMessage ="İzin başlangıç tarihi girmek zorunludur.")]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [Required(ErrorMessage ="Gün sayısı girilmek zorundadır.")]
    public float Days { get; set; }
    public Guid PermissionTypeId { get; set; }
    public  IEnumerable<PermissionTypeVM>? PermissionList { get; set; }
    public static string ValidateBaşlangıçTarihi(DateTime startDate)
    {
        if (startDate < DateTime.Now.AddDays(1).Date)
        {
            return "Start date must be on or after tomorrow.";
        }
        return "";
    }

}

