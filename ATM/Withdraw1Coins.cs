using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw1Coins : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _1CoinCount = 0;
        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }
        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 1)
            {
                while (request.amountLeft_ >= 1)
                {
                    _1CoinCount++;
                    request.amountLeft_ -= 1;
                }

                Console.WriteLine("You have withdrawed " + _1CoinCount + "x 1 coin(s).");

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
