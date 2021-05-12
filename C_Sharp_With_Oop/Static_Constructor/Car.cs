using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Static_Constructor
{
    class Car
    {
        static Car()
        {
            Console.WriteLine(@"Lamborghini is the best sports car owned by Audi AG 1998 (its static info)");
        }

        public static void Drive()
        {
            Console.WriteLine("Audi is the Stable Company");
        }
    }
}
