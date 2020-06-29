using System.Collections.Generic;

namespace CurancyCalculator.Models
{
    public class ExchangeRateDto
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public int TimeLastUpdated { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
