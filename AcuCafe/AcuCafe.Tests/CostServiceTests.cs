using AcuCafe.Application.Models;
using NUnit.Framework;

namespace AcuCafe.Tests
{
    public class CostServiceTests
    {
        [TestCase(1.8, false, false)]
        [TestCase(2.3, true, false)]
        [TestCase(2.3, false, true)]
        [TestCase(2.8, true, true)]
        [Test]
        public void AcuCafe_Espresso_Test(double cost, bool hasMilk, bool hasSugar)
        {
            var espresso = new Espresso {HasMilk = hasMilk, HasSugar = hasSugar };
            var result = espresso.Cost();
            
            Assert.AreEqual(cost, result);
        }

        [TestCase(1.0, false, false)]
        [TestCase(1.5, true, false)]
        [TestCase(1.5, false, true)]
        [TestCase(2.0, true, true)]
        [Test]
        public void AcuCafe_Tea_Test(double cost, bool hasMilk, bool hasSugar)
        {
            var hotTea = new Tea { HasMilk = hasMilk, HasSugar = hasSugar };
            var result = hotTea.Cost();

            Assert.AreEqual(cost, result);
        }

        [TestCase(1.5, false, false)]
        [TestCase(2.0, true, false)]
        [TestCase(2.0, false, true)]
        [TestCase(2.5, true, true)]
        [Test]
        public void AcuCafe_IceTea_Test(double cost, bool hasMilk, bool hasSugar)
        {
            var iceTea = new IceTea { HasMilk = hasMilk, HasSugar = hasSugar };
            var result = iceTea.Cost();

            Assert.AreEqual(cost, result);
        }
    }
}