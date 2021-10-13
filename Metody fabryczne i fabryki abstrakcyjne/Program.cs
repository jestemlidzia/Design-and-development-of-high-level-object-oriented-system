using System;
using System.Collections.Generic;

namespace LAB05_IceCreamFactory
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("IceCream Factory.\n\n");

            Days day = Days.Monday;

            IceCreamFactory factory = new IceCreamFactory(Days.Monday);
            IceCreamSeller seller = new IceCreamSeller(factory);

            for(int i = 0; i < 7; i++, day++)
            {
                factory.setProductionMode(day);
                Icecream ice = seller.ProposeIceCreamTaste();
                Console.WriteLine($"Today's special ({day}):\n {ice.ToString()}\n");
            }

        }
    }
}
