using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Permission.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class PermissionRequestListVM
{
    [Display(Name = "İzin Talep Numarası")]
    public Guid Id { get; set; }

    [Display(Name = "İzin Türü")]
    public PermissionTypeVM PermissionType { get; set; }
    [Display(Name = "Başlangıç Tarihi")]
    public DateTime StartDate { get; set; }
    [Display(Name = "Bitiş Tarihi")]
    public DateTime EndDate { get; set; }
    [Display(Name = "İzin Sayısı")]
    public float Days { get; set; }

    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
    [Display(Name = "Onay Tarihi")]
    public DateTime? ApprovalDate { get; set; }
}
