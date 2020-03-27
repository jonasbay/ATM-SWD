using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw500Notes : IWithdraw
    {
        private IWithdraw _nextInChain;
        private int _500noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            _nextInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 500)
            {
                while (request.amountLeft_ >= 500)
                {
                    _500noteCount++;
                    request.amountLeft_ -= 500;
                }

                Console.WriteLine("You have withdrawn " + _500noteCount + "x 500 note(s).");

                _nextInChain.Withdraw(request);
            }
            else
                _nextInChain.Withdraw(request);
        }
    }
}