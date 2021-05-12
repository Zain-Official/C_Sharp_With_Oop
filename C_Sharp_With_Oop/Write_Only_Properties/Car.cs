using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Write_Only_Properties
{
    class Car
    {
        private int model = -1;



        public int Model_No
        {
            set
            {
                 model=value;
            }
        }

        private string maker = string.Empty;
        public string maker_Name
        {
            set
            {
                maker = value;
            }
        }

        public void DisplayCustomerData()
        {
            Console.WriteLine("The Model Number of Car Is :-"+model);
            Console.WriteLine("The Model Name of Car IS :-"+maker);
        }
    }
}
