using FluentValidation.Validators;
using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public class AdvancePaymentListVM
{
    [Display(Name = "Avans Kimlik Numarası")]
    public Guid Id { get; set; }

    [Display(Name = "Avans Tipi")]
    public AdvanceTypeVM AdvanceType { get; set; }

    [Display(Name = "Miktarı")]
    public decimal Amount { get; set; }

    [Display(Name = "Para Birimi")]
    public CurrencyTypeVM CurrencyType { get; set; }

    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;

    [Display(Name = "Onay Tarihi")]
    public DateTime? ApprovalDate { get; set; }

    [Display(Name = "Açıklama")]
    public string Description { get; set; } = null!;

}
