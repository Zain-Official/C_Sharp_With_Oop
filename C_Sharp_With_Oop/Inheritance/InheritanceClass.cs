using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Inheritance
{
    class InheritanceClass
    {
        static void Main(string[] args)
        {
            Truck t = new Truck();
            Console.WriteLine("******************************");
            Electric e = new Electric();
            Console.WriteLine("******************************");
            Petrol p = new Petrol();

            Console.ReadKey();

        }
    }
}
