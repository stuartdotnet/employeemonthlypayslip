namespace EmployeeMonthlyPayslip
{
    public interface IPayslipGenerator
    {
        MonthlyPayslip GenerateMonthlyPayslip(string name, decimal annualSalary);
    }
}
