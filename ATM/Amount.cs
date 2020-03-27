using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class Amount
    {
        public double amount_ { get; }
        public double amountLeft_ { get; set; }

        public Amount(double amount)
        {
            amount_ = amount;
            amountLeft_ = amount;
        }
    }
}
