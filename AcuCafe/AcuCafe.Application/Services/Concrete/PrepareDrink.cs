using System;
using AcuCafe.Application.Services.Abstract;

namespace AcuCafe.Application.Services.Concrete
{
    public class PrepareDrink : IPrepareDrink
    {
            public void Prepare(string drink)
            {
                string message = "We are preparing the following drink for you: " + Description;
                if (HasMilk)
                {
                    message += "with milk";
                }
                else
                {
                    message += "without milk";
                }

                if (HasSugar)
                {
                    message += "with sugar";
                }
                else
                {
                    message += "without sugar";
                }

                Console.WriteLine(message);
            }
        
    }
}
