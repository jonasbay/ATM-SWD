using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw2Coins : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _2coinsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 2)
            {
                while (request.amountLeft_ >= 2)
                {
                    _2coinsCount++;
                    request.amountLeft_ -= 2;
                }

                Console.WriteLine("You have withdrawed " + _2coinsCount + " x 2 coins.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
