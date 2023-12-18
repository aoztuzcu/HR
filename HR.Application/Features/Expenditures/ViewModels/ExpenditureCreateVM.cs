using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.AdvancePayments.ViewModels.Validations;
using HR.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.ViewModels;

public class ExpenditureCreateVM
{
    public Guid PersonnelId { get; set; }
	public IEnumerable<ExpenditureType> ExpenditureTypes { get; set; }
    public Guid ExpenditureTypeId { get; set; }
	[Required(ErrorMessage = "Miktar boş geçilemez.")]
	[Range(1, 20000.00, ErrorMessage = "Miktar alanına 0 ile 20000 arasında değer yazabilirsiniz.")]
	//[CustomAmountValidation]
	public decimal Amount { get; set; }
    public CurrencyTypeVM CurrencyType { get; set; }
    public IFormFile Document { get; set; }
}

