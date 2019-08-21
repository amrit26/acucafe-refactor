using AcuCafe.Application.Models;
using AcuCafe.Application.Services.Abstract;
using System;

namespace AcuCafe.Application.Services.Concrete
{
    public class PrepareService : IPrepareService
    {
        public void Prepare(Preparation preparation)
        {
            var message = "We are preparing the following drink for you: " + preparation.Description;

            if (preparation.Drink == "Espresso")
            {
                message = ChocolateToppingOption(message);
            }

            if (preparation.HasMilk)
            {
                message += " with milk,";
            }
            else
            {
                message += " without milk,";
            }

            if (preparation.HasSugar)
            {
                message += " with sugar.";
            }
            else
            {
                message += " without sugar.";
            }

            if (preparation.Drink == "IceTea" && preparation.HasMilk)
            {
                message = "Inform Barista that the ice tea has milk in it.";
            }

            Console.WriteLine(message);
        }

        private static string ChocolateToppingOption(string message)
        {
            Console.WriteLine("Would you like chocolate topping? \n 1. Yes \n 2. No");
            var selection = Console.ReadLine();
            if (selection == "1" || selection == "Yes" || selection == "YES" || selection == "yes")
            {
                message += " with chocolate topping,";
            }

            return message;
        }
    }
}
