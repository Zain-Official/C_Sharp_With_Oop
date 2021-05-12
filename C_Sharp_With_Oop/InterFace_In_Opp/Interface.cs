using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.InterFace_In_Opp
{
    class Interface
    {
        interface ISupercar
        {
            /// Interface method declaration
            bool smartcar();
        }
        class mercedes : ISupercar
        {
            public mercedes()
            {
            }

            /// Interface method definition in the class that implements it
            public bool smartcar()
            {
                Console.WriteLine("you have smart car");
                return true;
            }
        }


        static void Main(string[] args)
        {

            ISupercar mycar = new mercedes();
            mycar.smartcar();
            Console.Read();

        }
    }
}
