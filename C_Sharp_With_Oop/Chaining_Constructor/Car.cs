using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Chaining_Constructor
{
    class Car
    {
        private string carname;
        private int modelname;
        private double engine;

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

        public int ModelName
        {
            get
            {
                return modelname;
            }
            set
            {
                modelname = value;
            }
        }

        public double Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }


        public Car(string carNAME)
        {
            CarName = carNAME;
        }

        public Car(int _model):this("Honda Civic")
            {
             ModelName=_model;
            }

        public Car(double _engine):this(2021)
        {
            Engine = _engine;
            Console.WriteLine("ModelName Of Year: {0}",CarName);
            Console.WriteLine("Model No Of Year: {0}",ModelName);
            Console.WriteLine("Engine Type: {0}",Engine);
        }

    }
}
