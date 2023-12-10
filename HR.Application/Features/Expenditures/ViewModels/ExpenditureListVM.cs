using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.ViewModels;

public class ExpenditureListVM
{
    [Display(Name = "Harcama Kimlik Numarası")]
    public Guid Id { get; set; }
    [Display(Name = "Avans Tipi")]
    public ExpenditureType ExpenditureType { get; set; }
    [Display(Name = "Miktarı")]
    public decimal Amount { get; set; }
    [Display(Name = "Para Birimi")]
    public CurrencyTypeVM CurrencyType { get; set; }
    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; }
    [Display(Name = "Cevaplanma Tarihi")]
    public DateTime? ApprovalDate { get; set; }
    public decimal ExchangeAmount { get; set; }
    [Display(Name = "Belge")]
    public string Document { get; set; }
}
