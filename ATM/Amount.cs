using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class Amount
    {
        public double amountLeft_ { get; set; }

        public Amount(double amount)
        {
            amountLeft_ = amount;
        }
    }
}
