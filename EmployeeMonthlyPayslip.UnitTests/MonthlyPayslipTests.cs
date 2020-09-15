using EmployeeMonthlyPayslip.Models;
using NUnit.Framework;

namespace EmployeeMonthlyPayslip.UnitTests
{
    /// <summary>
    /// Using Australian Tax Code
    /// </summary>
    public class MonthlyPayslipTests
    {
        [Test]
        public void NamePassed_SetsName()
        {
            var sut = new MonthlyPayslip<AustralianTaxCode>("Test", 0);

            Assert.AreEqual("Test", sut.Name);
        }

        [Test]
        public void SalaryPassed_GrossIncomeReturnsSalaryDividedBy12()
        {
            var sut = new MonthlyPayslip<AustralianTaxCode>("Test", 120000);

            Assert.AreEqual(10000, sut.GrossIncome);
        }

        [Test]
        public void IncomeTax_IsCalculatedIncomeTaxDividedBy12()
        {
            var sut = new MonthlyPayslip<AustralianTaxCode>("Test", 120000);

            Assert.AreEqual(1833, sut.MonthlyIncomeTax);
        }

        [Test]
        public void NetIncome_IsCalculatedCorrectly()
        {
            var sut = new MonthlyPayslip<AustralianTaxCode>("Test", 120000);

            Assert.AreEqual(8167, sut.NetIncome);
        }
    }
}