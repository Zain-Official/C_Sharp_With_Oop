using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Read_Only_Properties
{
    class ReadOnlyProperties
    {
        static void Main(string [] args)
        {
            Car sportCar = new Car();
            

            Console.WriteLine("Car Model is :- {0} And Car Name IS :- {1}",sportCar.ModelID,sportCar.Maker_Name);
           
        }
    }
}
