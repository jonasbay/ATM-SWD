using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw50Notes : IWithdraw
    {

        private IWithdraw nexInChain;
        private int _50NoteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ > 50)
            {
                while (request.amountLeft_ > 50)
                {
                    _50NoteCount++;
                    request.amountLeft_ -= 50;
                }

                Console.WriteLine("You have withdrawn " + _50NoteCount + " x 100 Notes.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);

        }
    }
}
