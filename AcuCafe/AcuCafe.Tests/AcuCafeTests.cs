using AcuCafe.Application.Services.Abstract;
using Moq;
using NUnit.Framework;

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
            var mock = new Mock<ICostService>();
            mock.Setup(foo => foo.Cost()).Returns();

            var acuCafe = AcuCafe.OrderDrink("HotChocolate", true, true);
            Assert.Pass();
        }
    }
}