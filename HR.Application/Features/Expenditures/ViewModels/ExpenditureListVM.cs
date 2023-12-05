using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.ViewModels;

public class ExpenditureListVM
{
    public Guid PersonnelId { get; set; }
    public Guid ExpenditureTypeId { get; set; }
    public decimal Amount { get; set; }
    public CurrencyTypeVM CurrencyType { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public decimal ExchangeAmount { get; set; }
    public string Document { get; set; }
}
