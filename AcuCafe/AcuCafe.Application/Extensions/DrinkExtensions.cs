using AcuCafe.Application.Constants;
using AcuCafe.Application.Models;
using System;

namespace AcuCafe.Application.Extensions
{
    public static class DrinkExtensions
    {
        public static Drink DrinkSelection(string type, out string description)
        {
            Drink drink;
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

            return drink;
        }
    }
}
