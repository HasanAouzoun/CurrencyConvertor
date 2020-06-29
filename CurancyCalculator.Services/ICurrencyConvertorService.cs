using System.Threading.Tasks;
using CurancyCalculator.Models;

namespace CurancyCalculator.Services
{
    public interface ICurrencyConvertorService
    {
        Task<double> CalculateRate(CurrencyConvertorRequest request);
    }
}