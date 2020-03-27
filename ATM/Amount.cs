using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class Amount
    {
        double amount_;
        public double amountLeft_ { get; set; }

        public Amount(double amount)
        {
            amount_ = amount;
            amountLeft_ = amount;
        }

        public double GetAmount() { return amount_; }


    }
}
