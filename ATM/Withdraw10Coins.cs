using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw10Coins : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _10coinsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 10)
            {
                while (request.amountLeft_ >= 10)
                {
                    _10coinsCount++;
                    request.amountLeft_ -= 10;
                }

                Console.WriteLine("You have withdrawn " + _10coinsCount + " x 10 coins.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
