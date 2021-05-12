using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Default_Constructor
{
    class Car
    {
        //Default_Constructor
        public Car()
        {

        }

        private int model = -1;
        private string maker = string.Empty;

        public int Model_No
        {
            get
            {
                return model;
            }
        }

        public string Maker_Name
        {
            get
            {
                return maker;
            }
        }


    }
}
