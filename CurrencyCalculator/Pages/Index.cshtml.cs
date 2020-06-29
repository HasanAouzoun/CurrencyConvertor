using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CurancyCalculator.Services;
using CurancyCalculator.Models;

namespace CurrencyCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICurrencyConvertorService _currencyConvertorService;

        public IndexModel(ICurrencyConvertorService currencyConvertorService)
        {
            _currencyConvertorService = currencyConvertorService;
        }

        [BindProperty]
        public CurrencyConvertorRequest CurrencyConvertorRequest { get; set; }
        public string ResultText { get; set; }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            var resultValue = await _currencyConvertorService.CalculateRate(CurrencyConvertorRequest);

            ResultText = $"{CurrencyConvertorRequest.Value} {CurrencyConvertorRequest.FromCurrencyCode} = {resultValue} {CurrencyConvertorRequest.ToCurrencyCode}";
        }
    }
}
