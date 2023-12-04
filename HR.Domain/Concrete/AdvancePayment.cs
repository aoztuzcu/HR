using HR.Domain.Base;
using HR.Domain.Enum;

namespace HR.Domain.Concrete;

public class AdvancePayment : BaseEntity
{
    // Navigation Property
    public Guid PersonnelId { get; set; }
    public Personnel? Personnel { get; set; }

    // Entity Properties
    public AdvanceType AdvanceType { get; set; }
    public decimal Amount { get; set; }
    public CurrencyType CurrencyType { get; set; }
    public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.ApprovalWaiting;
    public DateTime? ApprovalDate { get; set; }
    public string Description { get; set; } = null!;
}
