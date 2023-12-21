using HR.Domain.Base;
using HR.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class Expenditure : BaseEntity
{
    public decimal Amount { get; set; }
    public decimal ExchangeAmount { get; set; }
    public CurrencyType CurrencyType { get; set; }
    public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.ApprovalWaiting;
    public DateTime? ApprovedDate { get; set; }
    public string? Document { get; set; }

    // Nav Property
    public Guid ExpenditureTypeId { get; set; }
    public virtual ExpenditureType ExpenditureType { get; set; }
    public Guid PersonnelId { get; set; }
    public virtual Personnel Personnel { get; set; }
}
