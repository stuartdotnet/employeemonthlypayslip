using EmployeeMonthlyPayslip.Models;
using System;

namespace EmployeeMonthlyPayslip
{
    public class MonthlyPayslip<TaxCodeType> where TaxCodeType : ITaxCode
    {
        private const int PRECISION = 2;
        private readonly decimal _annualSalary;
        private ITaxCode _taxCode;

        public MonthlyPayslip(string name, decimal annualSalary)
        {
            _annualSalary = annualSalary;
            _taxCode = Activator.CreateInstance<TaxCodeType>();
            Name = name;

            MonthlyIncomeTax = 
                decimal.Round(IncomeTaxCalculator.CalculateIncomeTax(_annualSalary, _taxCode.Brackets) / 12, PRECISION, MidpointRounding.AwayFromZero);
        }

        public string Name { get; }
        public decimal GrossIncome => decimal.Round(_annualSalary / 12, PRECISION, MidpointRounding.AwayFromZero);
        public decimal MonthlyIncomeTax { get; }
        public decimal NetIncome => decimal.Round(GrossIncome - MonthlyIncomeTax, PRECISION, MidpointRounding.AwayFromZero);
    }
}
