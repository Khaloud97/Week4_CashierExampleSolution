using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_CashierExample
{
    internal class Cashier
    {
        private Ipayment payment;
        public Cashier(Ipayment payment)
        {
            this.payment = payment;
        }
        public void CheckOut(decimal amount)
        {
            payment.Pay(amount);
        }
    }
}
