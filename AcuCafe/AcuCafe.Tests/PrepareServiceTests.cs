using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Concrete;
using NUnit.Framework;
using System;
using System.IO;

namespace AcuCafe.Tests
{
    public class PrepareServiceTests
    {
        [TestCase("We are preparing the following drink for you: Espresso without milk, without sugar.", false, false, "")]
        [TestCase("We are preparing the following drink for you: Espresso without milk, with sugar.", false, true, "")]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, without sugar.", true, false, "1")]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, with sugar.", true, true, "Yes")]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, with sugar.", true, true, "YES")]
        [TestCase("We are preparing the following drink for you: Espresso with chocolate topping, with milk, with sugar.", true, true, "yes")]
        [Test]
        public void Preparation_Message_Of_Espresso_AreEqual(string message, bool hasMilk, bool hasSugar, string toppingInput)
        {
            var preparation = new Preparation
            {
                Drink = "Espresso",
                Description = "Espresso",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var preparationService = new PrepareService();
            
            var input = new StringReader(toppingInput);
            Console.SetIn(input);

            var result = preparationService.Prepare(preparation);

            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Hot tea without milk, without sugar.", false, false)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, without sugar.", true, false)]
        [TestCase("We are preparing the following drink for you: Hot tea without milk, with sugar.", false, true)]
        [TestCase("We are preparing the following drink for you: Hot tea with milk, with sugar.", true, true)]
        [Test]
        public void Preparation_Message_Of_Tea_AreEqual(string message, bool hasMilk, bool hasSugar)
        {
            var preparation = new Preparation
            {
                Drink = "Tea",
                Description = "Hot tea",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var preparationService = new PrepareService();
            
            var result = preparationService.Prepare(preparation);

            Assert.AreEqual(message, result);
        }

        [TestCase("We are preparing the following drink for you: Ice tea without milk, without sugar.", false, false)]
        [TestCase("Inform Barista that the ice tea has milk in it.", true, false)]
        [TestCase("We are preparing the following drink for you: Ice tea without milk, with sugar.", false, true)]
        [TestCase("Inform Barista that the ice tea has milk in it.", true, true)]
        [Test]
        public void Preparation_Message_Of_IceTea_AreEqual(string message, bool hasMilk, bool hasSugar)
        {
            var preparation = new Preparation
            {
                Drink = "IceTea",
                Description = "Ice tea",
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };

            var preparationService = new PrepareService();
            
            var result = preparationService.Prepare(preparation);

            Assert.AreEqual(message, result);
        }
    }
}