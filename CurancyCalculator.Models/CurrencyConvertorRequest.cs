namespace CurancyCalculator.Models
{
    public class CurrencyConvertorRequest
    {
        public FromCurrencyCode FromCurrencyCode { get; set; }
        public ToCurrencyCode ToCurrencyCode { get; set; }
        public double Value { get; set; }
    }
}
