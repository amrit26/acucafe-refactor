using AcuCafe.Application.Services.Concrete;
using AcuCafe.Models;
using System;

namespace AcuCafe.Application
{
    public class AcuCafe
    {
        public static Drink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            var drink = new Drink();
            var description = string.Empty;

            if (type == "Espresso")
            {
                drink = new Espresso();
                description = Models.Constants.Description.Espresso;
            }
            else if(type == "HotTea")
            {
                drink = new Tea();
                description = Models.Constants.Description.Tea;
            }
            else if (type == "IceTea")
            {
                drink = new IceTea();
                description = Models.Constants.Description.IceTea;
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