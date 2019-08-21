using AcuCafe.Application.Extensions;
using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Concrete;
using System;

namespace AcuCafe.Application
{
    public static class AcuCafe
    {
        public static Drink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            var drink = new Drink();
            try
            {
                drink = DrinkExtensions.DrinkSelection(type, out var description);

                var prepareService = new PrepareService();

                drink.HasMilk = hasMilk;
                drink.HasSugar = hasSugar;
                prepareService.Prepare(type, description, hasMilk, hasSugar);
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