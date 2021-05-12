using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.PolyMorphism
{
    class PolyMorPhism_Class
    {
        static void Main(string[] args)
        {
            Car cr = new Car();
            cr.CarDetail();
            cr.CarDetail(220000);
            cr.CarDetail(220000,"while") ;
            Console.ReadKey();
        }
    }
}
