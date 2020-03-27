using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw20Coins : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _20CoinCount = 0;
        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }
        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 20)
            {
                while (request.amountLeft_ >= 20)
                {
                    _20CoinCount++;
                    request.amountLeft_ -= 20;
                }

                Console.WriteLine("You have withdrawn " + _20CoinCount + " x 20 coins.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
