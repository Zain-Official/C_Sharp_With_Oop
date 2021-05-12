using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.ConstructorOverLoading
{
    class Over_Loading_Costructor
    {
        static void Main(string[] args)
        {
            Car sportsCar_1 = new Car();
            Car sportsCar_2 = new Car(2021,"Honda Civic");
            Car sportsCar_3 = new Car("Mehran",3.8);
            Console.WriteLine("");
            Console.WriteLine("***************Constructor Without Arguments***************");
            Console.WriteLine("Car Model Number I: {0}",sportsCar_1.model_ID);
            Console.WriteLine("Car Model Name Is: {0}",sportsCar_1.make_Name);
            Console.WriteLine("Car Engine Power IS: {0}",sportsCar_1.engine_Type);

            Console.WriteLine("");
            Console.WriteLine("**/////////////////////**Constructor With Two Arguments**/////////////////////**");
            Console.WriteLine("Car Model Number IS: {0}", sportsCar_2.model_ID);
            Console.WriteLine("Car Model Name Is: {0}", sportsCar_2.make_Name);
            Console.WriteLine("Car Engine Power IS: {0}", sportsCar_2.engine_Type);


            Console.WriteLine("");
            Console.WriteLine("**///^^^^^^^^^^^^^^^^^^^^^^/////**Constructor With Two Arguments**/////^^^^^^^^^^^^^^^^^^^^////**");
            Console.WriteLine("Car Model Number IS: {0}", sportsCar_3.model_ID);
            Console.WriteLine("Car Model Name Is: {0}", sportsCar_3.make_Name);
            Console.WriteLine("Car Engine Power IS: {0}", sportsCar_3.engine_Type);


            Console.ReadKey();


        }
    }
}
