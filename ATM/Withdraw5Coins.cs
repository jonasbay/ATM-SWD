using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw5Coins : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _5CoinCount = 0;
        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }
        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 5)
            {
                while (request.amountLeft_ >= 5)
                {
                    _5CoinCount++;
                    request.amountLeft_ -= 5;
                }

                Console.WriteLine("You have withdrawn " + _5CoinCount + " x 5 coin(s).");

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
