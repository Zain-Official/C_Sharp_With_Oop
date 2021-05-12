using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.LearnProperties
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            BikeColor bc;
            bc = new BikeColor("Black");
            Console.WriteLine("The Color Of Bike is "+bc._MyBikeColor);
            Console.ReadKey(); 
        }
    }
}
