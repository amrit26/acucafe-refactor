using System;

namespace AcuCafe.Program
{
    public class Program
    {
       public static void Main()
        {
            var test = Application.AcuCafe.OrderDrink("IceTea", false, true);
            Console.WriteLine(test);
        }
    }
}
