using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Services;

public interface ICurrencyService
{
    Task<decimal> GetExchangeRateAsync(string baseCurrency, string targetCurrency, DateTime date);
}
