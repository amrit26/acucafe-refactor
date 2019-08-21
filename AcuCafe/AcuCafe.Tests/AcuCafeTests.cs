using NUnit.Framework;
using AcuCafe.Application;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AcuCafe_Test1()
        {
            var acuCafe = AcuCafe.OrderDrink("HotChocolate", true, true);
            Assert.Pass();
        }
    }
}