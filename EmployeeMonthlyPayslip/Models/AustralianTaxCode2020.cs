using System.Collections.Generic;

namespace EmployeeMonthlyPayslip.Models
{
    public class AustralianTaxCode2020 : ITaxCode
    {
        public IEnumerable<TaxBracket> Brackets => new List<TaxBracket>
        {
            new TaxBracket { MinValue = 0, MaxValue = 18200, CostPerDollar = 0 },
            new TaxBracket { MinValue = 18201, MaxValue = 37000, CostPerDollar = 0.19M },
            new TaxBracket { MinValue = 37001, MaxValue = 90000, CostPerDollar = 0.325M },
            new TaxBracket { MinValue = 90001, MaxValue = 180000, CostPerDollar = 0.37M },
            new TaxBracket { MinValue = 180000, MaxValue = decimal.MaxValue, CostPerDollar = 0.45M }
        };
    }
}
