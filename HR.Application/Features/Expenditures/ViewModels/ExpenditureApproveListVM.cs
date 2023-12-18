using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.EnumViewModels;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.Expenditures.ViewModels;

public class ExpenditureApproveListVM
{
    public Guid Id { get; set; }

    //public Guid PersonnelId { get; set; }
    public PersonVM Personnel { get; set; }


    [Display(Name = "Avans Tipi")]
    public ExpenditureType ExpenditureType { get; set; }

    [Display(Name = "Miktarı")]
    public decimal Amount { get; set; }

    [Display(Name = "Para Birimi")]
    public CurrencyTypeVM CurrencyType { get; set; }

    public decimal ExchangeAmount { get; set; }
    [Display(Name = "Belge")]
    public string Document { get; set; }


    [Display(Name = "Cevaplanma Tarihi")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ApprovedDate { get; set; }

    [Display(Name = "Onay Durumu")]
    public ApprovalStatusVM ApprovalStatus { get; set; }










}
