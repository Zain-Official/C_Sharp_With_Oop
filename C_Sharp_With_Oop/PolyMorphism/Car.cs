using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.PolyMorphism
{
    class Car
    {
        public void CarDetail()
        {
            Console.WriteLine("Honda Civic Car Is Available");
        }
        public void CarDetail(int priceRange)
        {
            Console.WriteLine("Car V8 is Available its Expensive");
        }

        public void CarDetail(int priceRange,string color)
        {
            Console.WriteLine("Car Mehran Is Available in White Color");
        }

    }
}
