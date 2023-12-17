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
    public string? FormattedStartDate => StartDate.ToString("dd/MM/yyyy");

    [Display(Name = "Bitiş Tarihi")]
    public DateTime EndDate { get; set; }
    public string? FormattedEndDate => EndDate.ToString("dd/MM/yyyy");

    [Display(Name = "İzin Sayısı")]
    public float Days { get; set; }

    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;

    [Display(Name = "Cevaplanma Tarihi")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ApprovedDate { get; set; }
}
