using NUnit.Framework;

namespace EmployeeMonthlyPayslip.UnitTests
{
    public class AustralianPayslipGeneratorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TaxableIncomeZeroToTwentyThousand_ReturnsZero()
        {
            Assert.Pass();
        }

        [Test]
        public void TaxableIncome20001to40000_ReturnsTenCentsForEachDollarOver20000()
        {
            Assert.Pass();
        }

        [Test]
        public void TaxableIncome40001to80000_ReturnsTwentyCentsForEachDollarOver40000()
        {
            Assert.Pass();
        }

        [Test]
        public void TaxableIncome80001to180000_ReturnsThirtyCentsForEachDollarOver80000()
        {
            Assert.Pass();
        }

        [Test]
        public void TaxableIncome180001Plus_ReturnsFourtyCentsForEachDollarOver180000()
        {
            Assert.Pass();
        }
    }
}