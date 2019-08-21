using AcuCafe.Application.Builders.Abstract;
using AcuCafe.Application.Extensions;
using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Abstract;
using System;

namespace AcuCafe.Application
{
    public class AcuCafe
    {
        private readonly IPrepareService _prepareService;
        private readonly IPreparationBuilder _preparationBuilder;

        public AcuCafe(
            IPrepareService prepareService,
            IPreparationBuilder preparationBuilder)
        {
            _prepareService = prepareService;
            _preparationBuilder = preparationBuilder;
        }

        public Drink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            var drink = new Drink();
            try
            {
                drink = DrinkExtensions.DrinkSelection(type, out var description);

                var preparation = _preparationBuilder.Build(type, hasMilk, hasSugar, description);
                _prepareService.Prepare(preparation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are unable to prepare your drink. " + ex.Message);
                //System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return drink;
        }
    }
}