using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.LearnProperties
{
    class BikeColor
    {
        private string MyBikeColor;

        public string _MyBikeColor
        {
            get
            {
                return MyBikeColor;
            }
            set
            {
                MyBikeColor = value;
            }
        }

        public BikeColor(string userDemandColor)
        {
            this._MyBikeColor = userDemandColor;
        }
       
    }
}
