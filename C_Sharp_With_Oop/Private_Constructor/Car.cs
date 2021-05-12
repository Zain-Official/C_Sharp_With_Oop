using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Private_Constructor
{
    class Car
    {
        private string carname;

        //Private Constructor
        private Car()
        {
            CarName = "Honda Civic";
        }

        public string CarName
        {
            get
            {
                return carname;
            }
            set
            {
                carname = value;
            }
        }


        public Car(int Model) : this()
        {
            Console.WriteLine("Model Year: {0}",Model);
            Console.WriteLine("Maker Name: {0}",CarName);

        }
    }
}
