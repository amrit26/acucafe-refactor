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
            try
            {
                string description;

                switch (type)
                {
                    case "Espresso":
                        drink = new Espresso();
                        description = Description.Espresso;
                        break;
                    case "HotTea":
                        drink = new Tea();
                        description = Description.Tea;
                        break;
                    case "IceTea":
                        drink = new IceTea();
                        description = Description.IceTea;
                        break;
                    default:
                        throw new Exception("Drink selected not on the list.");
                }

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