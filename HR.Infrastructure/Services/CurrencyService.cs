using HR.Application.Contracts.Persistence.Services;
using System.Xml.Linq;

namespace HR.Persistence.Services;

public class CurrencyService : ICurrencyService
{
    private readonly HttpClient httpClient;

    // dependency injection ??
    public CurrencyService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<decimal> GetExchangeRateAsync(string baseCurrency, string targetCurrency, DateTime date)
    {
        string url = $"https://www.tcmb.gov.tr/kurlar/{date:yyyyMM}/{date:ddMMyyyy}.xml";

        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string xmlData = await response.Content.ReadAsStringAsync();
            XDocument document = XDocument.Parse(xmlData);

            // XML'den döviz kuru bilgisini çek
            var rateElement = document.Descendants("Currency")
                .Where(c => c.Element("CurrencyCode")?.Value == targetCurrency)
                .FirstOrDefault()?.Element("ForexBuying");

            if (rateElement != null && decimal.TryParse(rateElement.Value, out decimal exchangeRate))
                return exchangeRate;
            else
                throw new Exception("Exchange rate data not found.");
        }

        // Hata durumunda varsayılan olarak 1 döndürülebilir.
        throw new Exception($"Failed to retrieve exchange rate data. Status code: {response.StatusCode}");
    }
}
