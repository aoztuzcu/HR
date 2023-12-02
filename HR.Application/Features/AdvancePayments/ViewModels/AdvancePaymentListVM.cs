using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels;

public class AdvancePaymentListVM
{
    public Guid Id { get; set; }
    public AdvanceTypeVM AdvanceType { get; set; }
    public decimal Amount { get; set; }
    public CurrencyTypeVM CurrencyType { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
    public DateTime? ApprovalDate { get; set; }
    public string Description { get; set; } = null!;

}
