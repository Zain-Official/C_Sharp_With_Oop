using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_With_Oop.Encapsulation
{
    class Credit_Card_Info
    {
        private string customername = string.Empty;
        private string cardno = string.Empty;
        private double creditamount = -1;
        private double markuprate = -1;

        public Credit_Card_Info(string _cuntomername,string _cardno,double _cardamount,double _markuprate)
        {
            customername = _cuntomername;
            cardno = _cardno;
            creditamount = _cardamount;
            markuprate = _markuprate;
        }

        public double disbursement
        {
            get
            {
                return creditamount;
            }

            set
            {
                creditamount = creditamount + value;
                creditamount = creditamount * markuprate / 100 + creditamount;
            }
        }

        public void Display()
        {
            Console.WriteLine("Customer Name : {0}",customername);
            Console.WriteLine("Card No : {0}",cardno);
            Console.WriteLine("Mark up Rate : {0}",markuprate);
            Console.WriteLine("Total Credit Amount : {0}",creditamount);
        }
    }
}
