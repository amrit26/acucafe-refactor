using System;

namespace AcuCafe.Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var blah = Application.AcuCafe.OrderDrink("HotChocolate", true, true);
            Console.WriteLine(blah);
        }
    }
}
