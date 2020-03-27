using System;
using System.Reflection.Metadata.Ecma335;

namespace ATM
{
    public class chainEnd : IWithdraw
    {

        private IWithdraw nexInChain;
        private int _100noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            Console.WriteLine("You cannot attach chain links to the end");
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ > 0)
                Console.WriteLine("Unable to withdraw the last " + request.amountLeft_ + ".\nWithdraw complete");
            else Console.WriteLine("Withdraw complete");
        }
    }
}