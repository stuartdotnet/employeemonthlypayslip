using System.Collections.Generic;

namespace EmployeeMonthlyPayslip.Models
{
    public class AustralianTaxCode : ITaxCode
    {
        public IEnumerable<TaxBracket> Brackets => new List<TaxBracket>
        {
            new TaxBracket { MinValue = 0, MaxValue = 20000, CostPerDollar = 0 },
            new TaxBracket { MinValue = 20001, MaxValue = 40000, CostPerDollar = 0.1M },
            new TaxBracket { MinValue = 40001, MaxValue = 80000, CostPerDollar = 0.2M },
            new TaxBracket { MinValue = 80001, MaxValue = 180000, CostPerDollar = 0.3M },
            new TaxBracket { MinValue = 180000, MaxValue = decimal.MaxValue, CostPerDollar = 0.4M }
        };
    }
}
