using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw100Bills : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _100billsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ > 100)
            {
                while (request.amountLeft_ > 100)
                {
                    _100billsCount++;
                    request.amountLeft_ -= 100;
                }

                Console.WriteLine("You have withdrawed " + _100billsCount + " x 100 dollar bills.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
