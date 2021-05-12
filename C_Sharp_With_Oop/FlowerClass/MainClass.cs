using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.C_Sharp_Basic
{
    class MainClass
    {
        static void Main(string[] args)
        {

            SET_Condtion s = new SET_Condtion();
            s.EnterColor("Yellow");

            Console.WriteLine(s.Display());


            Console.ReadKey();
        }
    }
}
