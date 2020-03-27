using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Withdraw50Ears : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _50earsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 0.5)
            {
                while (request.amountLeft_ >= 0.5)
                {
                    _50earsCount++;
                    request.amountLeft_ -= 0.5;
                }

                Console.WriteLine("You have withdrawed " + _50earsCount + " x 50 ear(s).");

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}
