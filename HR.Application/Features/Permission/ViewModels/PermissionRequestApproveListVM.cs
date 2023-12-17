using HR.Application.Features.EnumViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.ViewModels;

public class PermissionRequestApproveListVM
{
    public Guid Id { get; set; }

    //public Guid PersonnelId { get; set; }

    public PersonVM Personnel { get; set; }

    [Display(Name ="Başlangıç Tarihi")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [Display(Name = "Bitiş Tarihi")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime EndDate { get; set; }

    [Display(Name = "Gün")]
    public float Days { get; set; }

    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; }

    [Display(Name = "Cevaplanma Tarihi")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ApprovedDate { get; set; }

    public Guid PermissionTypeId { get; set; }

    public PermissionTypeVM? PermissionType { get; set; }
}
