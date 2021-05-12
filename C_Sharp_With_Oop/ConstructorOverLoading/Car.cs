using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.ConstructorOverLoading
{
    class Car
    {
        private int model = -1;
        private string maker = string.Empty;
        private double engintype = 0.0;

        //Default Constructor
        public Car()
        {

        }

        //parameteriaze Constructor

        public Car(int _Model,string _Maker)
        {
            this.model = _Model;
            this.maker = _Maker;
        }

        //parameteriaze Constructor 2nd

        public Car(string _maker,double _power)
        {
            this.maker = _maker;
            this.engintype = _power;
        }




        //setting Properties (get and Set for All Private Variables)

        //For Private model
        public int model_ID
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }

        }

        //For Private maker
        public string make_Name
        {
            get
            {
                return maker;
            }
            set
            {
                maker = value;
            }
        }

        //For Private engintype
        public double engine_Type
        {
            get
            {
                return engintype;
            }

            set
            {
                engintype = value;
            }
        }


    }
}
