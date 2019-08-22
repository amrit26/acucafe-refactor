using AcuCafe.Application.Logging.Abstract;
using System;

namespace AcuCafe.Application.Logging.Concrete
{
    public class Logger : ILogger
    {
        public void PreparationMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void UnableToPrepareDrinkMessage(Exception ex)
        {
            Console.WriteLine("We are unable to prepare your drink. " + ex.Message);
        }
    }
}
