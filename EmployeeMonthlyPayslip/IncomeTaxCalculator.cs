using EmployeeMonthlyPayslip.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeMonthlyPayslip
{
    public static class IncomeTaxCalculator
    {
        public static decimal CalculateIncomeTax(decimal annualIncome, IEnumerable<TaxBracket> taxBrackets)
        {
            decimal incomeTax = 0;
            decimal prevMax = 0;

            var applicableTaxBrackets = taxBrackets
                .Where(t => t.MinValue < annualIncome)
                .OrderBy(t => t.MinValue);

            foreach (var bracket in applicableTaxBrackets)
            {
                if (annualIncome >= bracket.MaxValue)
                {
                    incomeTax +=  (bracket.MaxValue - prevMax) * bracket.CostPerDollar;
                }
                else
                {
                    incomeTax += (annualIncome - prevMax) * bracket.CostPerDollar;
                }
                prevMax = bracket.MaxValue;
            }

            return incomeTax;
        }
    }
}
