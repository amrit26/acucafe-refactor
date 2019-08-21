using AcuCafe.Application.Services.Abstract;
using Moq;
using NUnit.Framework;

namespace AcuCafe.Tests
{
    public class PrepareServiceTests
    {
        public Mock<IPrepareService> _prepareService;

        [SetUp]
        public void SetUp()
        {
            _prepareService = new Mock<IPrepareService>();
        }

        [TestCase("We are preparing the following drink for you: Espresso without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Espresso with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Espresso without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Espresso with milk, with sugar.", true, true)]
        [Test]
        public void AcuCafe_EspressoMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var result = _prepareService.Setup(x => x.Prepare("Espresso", "Espresso", hasMilk, hasSugar));
            
            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Hot tea without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Hot tea without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, with sugar.", true, true)]
        [Test]
        public void AcuCafe_TeaMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var result = _prepareService.Setup(x => x.Prepare("Tea", "Hot tea", hasMilk, hasSugar));

            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Ice tea without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Ice tea with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Ice tea without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Ice tea with milk, with sugar.", true, true)]
        [Test]
        public void AcuCafe_IceTeaMessage_Test(string message, bool hasMilk, bool hasSugar)
        {
            var result = _prepareService.Setup(x => x.Prepare("IceTea", "Ice tea", hasMilk, hasSugar));

            Assert.AreEqual(message, result);
        }
    }
}