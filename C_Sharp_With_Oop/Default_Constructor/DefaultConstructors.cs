using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Default_Constructor
{
    class DefaultConstructors
    {
        static void Main(string[] args)
        {
            Car sportsCar = new Car();

            Console.WriteLine("Car Model Number is {0}",sportsCar.Model_No);
            Console.WriteLine("Car Model Name Is {0}",sportsCar.Maker_Name);

            Console.ReadKey();

        }
    }
}
