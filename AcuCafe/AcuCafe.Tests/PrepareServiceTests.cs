using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Abstract;
using Moq;
using NUnit.Framework;

namespace AcuCafe.Tests
{
    public class PrepareServiceTests
    {
        public Mock<IPrepareService> PrepareService;

        [SetUp]
        public void SetUp()
        {
            PrepareService = new Mock<IPrepareService>();
        }

        [TestCase("We are preparing the following drink for you: Espresso without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Espresso without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, with sugar.", true, true)]
        [Test]
        public void AcuCafe_EspressoMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var preparation = new Preparation
            {
                Drink = "Espresso",
                Description = "Espresso",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var result = PrepareService.Setup(x => x.Prepare(preparation));
            
            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Hot tea without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Hot tea without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, with sugar.", true, true)]
        [Test]
        public void AcuCafe_TeaMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var preparation = new Preparation
            {
                Drink = "Tea",
                Description = "Hot tea",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var result = PrepareService.Setup(x => x.Prepare(preparation));

            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Ice tea without milk, without sugar.", false, false)]
        [TestCase("Inform Barista that the ice tea has milk in it.", true, false)]
        [TestCase("We are preparing the following drink for you: Ice tea without milk, with sugar.", false, true)]
        [TestCase("Inform Barista that the ice tea has milk in it.", true, true)]
        [Test]
        public void AcuCafe_IceTeaMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var preparation = new Preparation
            {
                Drink = "IceTea",
                Description = "Ice tea",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var result = PrepareService.Setup(x => x.Prepare(preparation));

            Assert.AreEqual(message, result);
        }
    }
}