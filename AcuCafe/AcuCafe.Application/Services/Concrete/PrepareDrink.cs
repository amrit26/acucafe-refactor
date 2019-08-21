using AcuCafe.Application.Services.Abstract;
using System;

namespace AcuCafe.Application.Services.Concrete
{
    public class PrepareDrink : IPrepareDrink
    {
            public void Prepare(string drink, string description, bool hasMilk, bool hasSugar)
            {
                string message = "We are preparing the following drink for you: " + description;
                if (hasMilk)
                {
                    message += " with milk";
                }
                else
                {
                    message += " without milk";
                }

                if (hasSugar)
                {
                    message += " with sugar";
                }
                else
                {
                    message += " without sugar";
                }

                Console.WriteLine(message);
            }
        
    }
}
