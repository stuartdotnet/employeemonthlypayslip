using EmployeeMonthlyPayslip.Models;

namespace EmployeeMonthlyPayslip
{
    public interface IPayslipGenerator<T> where T : ITaxCode
    {
        MonthlyPayslip<T> GenerateMonthlyPayslip(string name, decimal annualSalary);
    }
}
