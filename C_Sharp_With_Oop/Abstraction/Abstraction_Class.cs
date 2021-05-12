using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Abstraction
{
    class Abstraction_Class
    {
        static void Main(string[] args)
        {
            NetPay o = new NetPay();
            o.CalculatePay();
            Console.WriteLine("Officer Grad II pay = {0} \nOfficer Grad I pay = {1}", o.GradeTwo, o.GradeOne);
            Console.ReadKey();

        }
    }
}
