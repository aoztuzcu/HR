using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.ViewModels;

public class ExpenditureCreateVM
{
    public Guid PersonnelId { get; set; }
    public IEnumerable<ExpenditureType> ExpenditureTypes { get; set; }
    public decimal Amount { get; set; }
    public CurrencyTypeVM CurrencyTypeVM { get; set; }
    public IFormFile Document { get; set; }
}

