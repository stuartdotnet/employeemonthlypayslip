using EmployeeMonthlyPayslip.Models;
using NUnit.Framework;

namespace EmployeeMonthlyPayslip.UnitTests
{
    public class IncomeTaxCalculatorTestsForAustralianTax
    {
        private readonly ITaxCode taxCode = new AustralianTaxCode();
        [Test]
        public void TaxableIncomeZero_ReturnsZero()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(0, taxCode.Brackets);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TaxableIncomeTwentyThousand_ReturnsZero()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(20000, taxCode.Brackets);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TaxableIncome40000_ReturnsTenCentsForEachDollarOver20000()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(40000, taxCode.Brackets);

            // (20k x 0) + ((40k - 20k) * 0.1))
            // 0         +       2000
            Assert.AreEqual(2000, result);
        }

        [Test]
        public void TaxableIncome60000_ReturnsTwentyCentsForEachDollarOver40000()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(60000, taxCode.Brackets);

            // (20k x 0) + ((40k - 20k) * 0.1)) + ((60k - 40k) * 0.2))
            // 0         +       2000           +       4000
            Assert.AreEqual(6000, result);
        }

        [Test]
        public void TaxableIncome80000_ReturnsTwentyCentsForEachDollarOver40000()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(80000, taxCode.Brackets);

            // (20k x 0) + ((40k - 20k) * 0.1)) + ((80k - 40k) * 0.2))
            // 0         +       2000           +       8000
            Assert.AreEqual(10000, result);
        }

        [Test]
        public void TaxableIncome180000_ReturnsThirtyCentsForEachDollarOver80000()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(180000, taxCode.Brackets);

            // (20k x 0) + ((40k - 20k) * 0.1)) + ((80k - 40k) * 0.2)) + ((180k - 80k) * 0.3))
            // 0         +       2000           +       8000          +      30000
            Assert.AreEqual(40000, result);
        }

        [Test]
        public void TaxableIncome280000_ReturnsFourtyCentsForEachDollarOver180000()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(280000, taxCode.Brackets);

            // (20k x 0) + ((40k - 20k) * 0.1)) + ((80k - 40k) * 0.2)) + ((180k - 80k) * 0.3)) + ((280k - 180k) * 0.4))
            // 0         +       2000           +       8000           +      30000            +         40000
            Assert.AreEqual(80000, result);
        }

        /// <summary>
        /// I realised the tax rates in the exercise were out of date so did this for fun
        /// </summary>
        [Test]
        public void TaxableIncome2020_CalculatesCorrectly()
        {
            var result = IncomeTaxCalculator.CalculateIncomeTax(120000, new AustralianTaxCode2020().Brackets);

            Assert.AreEqual(31897, result);
        }
    }
}
