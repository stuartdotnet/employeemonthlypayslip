namespace EmployeeMonthlyPayslip
{
    public class MonthlyPayslip
    {
        private decimal _annualSalary;

        public MonthlyPayslip(string name, decimal annualSalary)
        {
            Name = name;
            _annualSalary = annualSalary;
        }

        public string Name { get; }
        public decimal GrossIncome => _annualSalary / 12;
        public decimal MonthlyIncomeTax { get; set; }
        public decimal NetIncome => GrossIncome - MonthlyIncomeTax;
    }
}
