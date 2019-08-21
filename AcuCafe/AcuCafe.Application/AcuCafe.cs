using AcuCafe.Application.Constants;
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
            var description = string.Empty;

            if (type == "Espresso")
            {
                drink = new Espresso();
                description = Description.Espresso;
            }
            else if(type == "HotTea")
            {
                drink = new Tea();
                description = Description.Tea;
            }
            else if (type == "IceTea")
            {
                drink = new IceTea();
                description = Description.IceTea;
            }

            var prepareService = new PrepareDrink();

            try
            {
                drink.HasMilk = hasMilk;
                drink.HasSugar = hasSugar;
                prepareService.Prepare(type, description, hasMilk, hasSugar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are unable to prepare your drink.");
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return drink;
        }
    }
}