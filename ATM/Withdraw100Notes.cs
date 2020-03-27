using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw100Notes : IWithdraw
    {
        private IWithdraw _nextInChain;
        private int _100noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            _nextInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 100)
            {
                while (request.amountLeft_ >= 100)
                {
                    _100noteCount++;
                    request.amountLeft_ -= 100;
                }

                Console.WriteLine("You have withdrawn " + _100noteCount + "x 100 dollar bills.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                _nextInChain.Withdraw(request);
            }
            else
                _nextInChain.Withdraw(request);
        }
    }
}
