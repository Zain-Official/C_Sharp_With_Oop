using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Read_Only_Properties
{
    class Car
    {
        private int model=2012;
        private string maker="mercedes";

        public int ModelID
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
