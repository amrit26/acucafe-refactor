using AcuCafe.Application.Builders.Concrete;
using AcuCafe.Application.Services.Concrete;
using System;

namespace AcuCafe.Program
{
    public class Program
    {
        public static void Main()
        {
            var acuCafe = new Application.AcuCafe(new PrepareService(), new PreparationBuilder());
            var test = acuCafe.OrderDrink("Espresso", true, false);
            Console.WriteLine(test);
        }
    }
}
