using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Abstraction
{
    class NetPay:Pay
    {
        public void CalculatePay()
        {
            _netPay= _basicPay + _houseRent + _tex;
        }

        public override int GradeTwo
        {
            get
            {
                return _netPay;
            }
        }

        public override int GradeOne
        {
            get
            {
                return _netPay = _netPay + _netPay * 10 / 100;
            }
        }
    }
}
