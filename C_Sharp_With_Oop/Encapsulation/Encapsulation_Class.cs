using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Encapsulation
{
    class Encapsulation_Class
    {
        static void Main(string[] args)
        {
            Credit_Card_Info cd = new Credit_Card_Info("Zain ul Aabdeen","1234kijf5754",6630,20.7);
            cd.disbursement = 2230;
            cd.Display();
            Console.ReadKey();
        }

    }
}
