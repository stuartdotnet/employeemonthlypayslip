using System.Diagnostics;

namespace EmployeeMonthlyPayslip.Models
{
    [DebuggerDisplay("{MinValue}-{MaxValue} {CostPerDollar} for each dollar over {MinValue}")]
    public class TaxBracket
    {
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal CostPerDollar { get; set; }
    }
}