using System;

namespace ATM
{
    public class Withdraw200Notes : IWithdraw
    {
        private IWithdraw _nextInChain;
        private int _200noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            _nextInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ >= 200)
            {
                while (request.amountLeft_ >= 200)
                {
                    _200noteCount++;
                    request.amountLeft_ -= 200;
                }

                Console.WriteLine("You have withdrawn " + _200noteCount + "x 200 note(s).");

                _nextInChain.Withdraw(request);
            }
            else
                _nextInChain.Withdraw(request);
        }
    }
}