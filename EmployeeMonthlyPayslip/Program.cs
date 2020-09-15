using System;
using System.Text.RegularExpressions;

namespace EmployeeMonthlyPayslip
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            decimal salary = 0;
            do
            {
                Console.WriteLine("Please enter GenerateMonthlyPayslip \"<name>\" <annualsalary> - eg GenerateMonthlyPayslip \"Bob Loblaw\" 120000");

                var input = Console.ReadLine();

                if (!CleanupInput(input, ref name, ref salary)) continue;

                var payslipGenerator = new AustralianPayslipGenerator();

                var payslip = payslipGenerator.GenerateMonthlyPayslip(name, salary);

                Console.WriteLine();
                Console.WriteLine($"Monthly Payslip for: {name}");
                Console.WriteLine($"Gross Monthly Income: {payslip.GrossIncome}");
                Console.WriteLine($"Monthly Income Tax: {payslip.MonthlyIncomeTax}");
                Console.WriteLine($"Net Monthly Income: {payslip.NetIncome}");
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the main menu");
                Console.ReadLine();
            } while (true); // There is no escape
        }

        private static bool CleanupInput(string input, ref string name, ref decimal salary)
        {
            input = input.Replace("GenerateMonthlyPayslip", "");

            var nameText = Regex.Match(input, "\".*?\"").Value;

            if (string.IsNullOrEmpty(nameText))
            {
                Console.WriteLine("Invalid name"); // or just log
                return false;
            }

            name = nameText.Replace("\"", "").Replace("\\", "");

            var salaryInput = Regex.Match(input, @"\d+").Value;

            if (!decimal.TryParse(salaryInput, out salary))
            {
                Console.WriteLine("Please supply a valid numeric salary");
                return false; 
            }

            return true;
        }

    }
}
