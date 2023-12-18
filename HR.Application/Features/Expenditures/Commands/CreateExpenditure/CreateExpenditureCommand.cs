using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Commands.CreateExpenditure;

public class CreateExpenditureCommand : IRequest<CreateExpenditureCommand>
{
    public Guid PersonnelId { get; set; }
    public Guid ExpenditureTypeId { get; set; }
    public CurrencyTypeVM CurrencyTypeVM { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
    public decimal Amount { get; set; }
    public DateTime? ApprovedDate { get; set; }
    public string? Document { get; set; }

}
