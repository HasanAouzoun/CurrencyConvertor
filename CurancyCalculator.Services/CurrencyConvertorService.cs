using System.Threading.Tasks;
using CurancyCalculator.Models;

namespace CurancyCalculator.Services
{
    public class CurrencyConvertorService : ICurrencyConvertorService
    {
        private readonly IExchangeRateApi _exchangeRateApi;

        public CurrencyConvertorService(IExchangeRateApi exchangeRateApi)
        {
            _exchangeRateApi = exchangeRateApi;
        }

        public async Task<double> CalculateRate(CurrencyConvertorRequest request)
        {
            // Get rate value
            var rate = await _exchangeRateApi.GetExchangeRateValue(request.FromCurrencyCode.ToString(), request.ToCurrencyCode.ToString());

            // Calculate and return
            return request.Value * rate;
        }
    }
}
