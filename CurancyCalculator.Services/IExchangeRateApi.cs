using System.Threading.Tasks;
using CurancyCalculator.Models;

namespace CurancyCalculator.Services
{
    public interface IExchangeRateApi
    {
        Task<ExchangeRateDto> GetExchagneRates(string baseCurrencyCode);
        Task<double> GetExchangeRateValue(string fromCurrencyCode, string toCurrencyCode);
    }
}
