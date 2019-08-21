using AcuCafe.Models;
using System;

namespace AcuCafe.Application
{
    public class AcuCafe
    {
        public static Drink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            Drink drink = new Drink();
            if (type == "Espresso")
            {
                drink = new Espresso();
            }
            else if(type == "HotTea")
            {
                drink = new Tea();
            }
            else if (type == "IceTea")
            {
                drink = new IceTea();
            }

            try
            {
                drink.HasMilk = hasMilk;
                drink.HasSugar = hasSugar;
                drink.Prepare(type);
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