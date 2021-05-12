using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.C_Sharp_Basic
{
    class SET_Condtion
    {
        private string Flower_COLOR;
        public string FlowerColor
        {
            get
            {
                return Flower_COLOR;
            }
            set
            {
                Flower_COLOR = value;
            }
        }
       
        public void EnterColor(string color)
        {
            this.FlowerColor = color;
        }
        public string Display()
        {
            return "Color Of Flower IS: " + this.FlowerColor;
        }
        
    }
}
