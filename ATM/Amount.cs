using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class Amount
    {
        double amount_;
        double amountLeft_;

        public Amount(double amount)
        {
            amount_ = amount;
            amountLeft_ = amount;
        }

        public double GetAmount() { return amount_; }

        public double AmountLeft {  get ; set; }
    }
}
