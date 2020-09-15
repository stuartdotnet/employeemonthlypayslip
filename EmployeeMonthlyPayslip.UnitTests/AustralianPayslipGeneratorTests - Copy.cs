using NUnit.Framework;

namespace EmployeeMonthlyPayslip.UnitTests
{
    public class MonthlyPayslipTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NamePassed_SetsName()
        {
            var sut = new MonthlyPayslip("Test", 0);

            Assert.AreEqual("Test", sut.Name);
        }

        [Test]
        public void SalaryPassed_GrossIncomeReturnsSalaryDividedBy12()
        {
            var sut = new MonthlyPayslip("Test", 120000);

            Assert.AreEqual(12000, sut.GrossIncome);
        }
    }
}