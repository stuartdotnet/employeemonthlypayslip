namespace EmployeeMonthlyPayslip
{
    public class AustralianPayslipGenerator : IPayslipGenerator
    {
        public MonthlyPayslip GenerateMonthlyPayslip(string name, decimal annualSalary)
        {
            return new MonthlyPayslip(name, annualSalary);
        }
    }
}
