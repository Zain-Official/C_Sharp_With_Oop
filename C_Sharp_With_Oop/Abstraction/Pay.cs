using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Abstraction
{
    abstract class Pay
    {
        protected int _basicPay = 20000;
        protected int _houseRent = 15000;
        protected int _tex = -500;
        protected int _netPay = -500;

        public abstract int GradeTwo { get; }
        public abstract int GradeOne { get; }




    }
}
