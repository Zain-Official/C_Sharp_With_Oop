using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.With_Out_Property
{
    class AutoImplementedproperty
    {
       static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_Name = "Ferrari";
            c.Maker = 2018;
            Console.WriteLine("The Car Model Name Is :- {0} And The Car Maker No Is :- {1}",c.Model_Name,c.Maker);
          

            Console.ReadKey();
        }
    }
}
