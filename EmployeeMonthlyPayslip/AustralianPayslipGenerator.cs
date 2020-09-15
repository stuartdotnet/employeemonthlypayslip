using EmployeeMonthlyPayslip.Models;

namespace EmployeeMonthlyPayslip
{
    public class AustralianPayslipGenerator : IPayslipGenerator<AustralianTaxCode>
    {
        public MonthlyPayslip<AustralianTaxCode> GenerateMonthlyPayslip(string name, decimal annualSalary)
        {
            return new MonthlyPayslip<AustralianTaxCode>(name, annualSalary);
        }
    }
}
