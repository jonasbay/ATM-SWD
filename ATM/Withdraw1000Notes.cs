using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw1000Notes : IWithdraw
    {
        private IWithdraw _nextInChain;
        private int _1000noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            _nextInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 1000)
            {
                while (request.amountLeft_ >= 1000)
                {
                    _1000noteCount++;
                    request.amountLeft_ -= 1000;
                }

                Console.WriteLine("You have withdrawn " + _1000noteCount + "x 1000 note(s).");

                _nextInChain.Withdraw(request);
            }
            else
                _nextInChain.Withdraw(request);
        }
    }
}
