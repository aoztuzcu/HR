using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Permission.ViewModels;
using System.ComponentModel.DataAnnotations;

public class PermissionRequestListVM
{
    [Display(Name = "İzin Talep Numarası")]
    public Guid Id { get; set; }

    public Guid PermissionTypeId { get; set; }
   
    public PermissionTypeVM? PermissionType { get; set; }

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
