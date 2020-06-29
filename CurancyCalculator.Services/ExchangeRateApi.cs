using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using CurancyCalculator.Models;

namespace CurancyCalculator.Services
{
    public class ExchangeRateApi : IExchangeRateApi
    {
        private readonly string _apiUrl;

        public ExchangeRateApi(IConfiguration conf)
        {
            _apiUrl = conf["ExchangeRateApiUrl"];
        }

        public async Task<ExchangeRateDto> GetExchagneRates(string baseCurrencyCode)
        {
            var client = new HttpClient();
            var request = await client.GetAsync($"{_apiUrl}{baseCurrencyCode}");

            var jsonResult = request.Content.ReadAsStringAsync().Result;
            var exchangeRateData = JsonConvert.DeserializeObject<ExchangeRateDto>(jsonResult);

            return exchangeRateData;
        }

        public async Task<double> GetExchangeRateValue(string fromCurrencyCode, string toCurrencyCode)
        {
            var exchangeRates = await GetExchagneRates(toCurrencyCode);

            return exchangeRates.Rates[fromCurrencyCode];
        }
    }
}
