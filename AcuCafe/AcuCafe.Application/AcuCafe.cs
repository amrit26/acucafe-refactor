using AcuCafe.Application.Builders.Abstract;
using AcuCafe.Application.Extensions;
using AcuCafe.Application.Logging.Abstract;
using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Abstract;
using System;

namespace AcuCafe.Application
{
    public class AcuCafe
    {
        private readonly IPrepareService _prepareService;
        private readonly IPreparationBuilder _preparationBuilder;
        private readonly ILogger _logger;

        public AcuCafe(
            IPrepareService prepareService,
            IPreparationBuilder preparationBuilder,
            ILogger logger)
        {
            _prepareService = prepareService;
            _preparationBuilder = preparationBuilder;
            _logger = logger;
        }

        public Drink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            var drink = new Drink();
            try
            {
                drink = DrinkExtensions.DrinkSelection(type, out var description);

                var preparation = _preparationBuilder.Build(type, hasMilk, hasSugar, description);
                var message = _prepareService.Prepare(preparation);
                _logger.PreparationMessage(message);
            }
            catch (Exception ex)
            {
                _logger.UnableToPrepareDrinkMessage(ex); 
                //System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return drink;
        }
    }
}