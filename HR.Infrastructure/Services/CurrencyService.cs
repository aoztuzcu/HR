using HR.Application.Contracts.Persistence.Services;
using System.Globalization;
using System.Xml.Linq;

namespace HR.Persistence.Services;

public class CurrencyService : ICurrencyService
{
    private readonly HttpClient httpClient;

    public CurrencyService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<decimal> GetExchangeRateAsync(string baseCurrency, string targetCurrency, DateTime date)
    {
        // Eğer tarih cumartesi veya pazar ise geçmiş cuma gününe çevir
        if (date.DayOfWeek == DayOfWeek.Saturday)
            date = date.AddDays(-1);

        else if (date.DayOfWeek == DayOfWeek.Sunday)
            date = date.AddDays(-2);

        // eğer saat 15:30'den önce ise bir önceki kur ile hesapla
        // Merkez Bankası günlük kuru 15.30 gibi açıklıyor. Bu saatten sonra veri doluyor.
        // Aksi halde page not found hatası veriyor MB'nin sitesi.

        TimeSpan cutoffTime = new TimeSpan(15, 30, 0);
        if (date.DayOfWeek != DayOfWeek.Monday && date.TimeOfDay < cutoffTime)
        {
            // Eğer şart sağlanıyorsa bir gün çıkartın
            date = date.AddDays(-1);
        }
        else if (date.DayOfWeek == DayOfWeek.Monday && date.TimeOfDay < cutoffTime)
        {
            date = date.AddDays(-3);
        }

        string url = $"https://www.tcmb.gov.tr/kurlar/{date:yyyyMM}/{date:ddMMyyyy}.xml";

        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string xmlData = await response.Content.ReadAsStringAsync();
            XDocument document = XDocument.Parse(xmlData);

            // XML'den döviz kuru bilgisini çek
            var rateElement = document.Descendants("Currency")
                                .Where(c => c.Attribute("CurrencyCode")?.Value == targetCurrency)
                                .FirstOrDefault()?.Element("ForexBuying");

            if (rateElement != null && decimal.TryParse(rateElement.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal exchangeRate))
                return exchangeRate;

            else
                throw new Exception("Exchange rate data not found.");
        }
        throw new Exception($"Failed to retrieve exchange rate data. Status code: {response.StatusCode}");
    }
}
