using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw50Bills : IWithdraw
    {

        private IWithdraw nexInChain;
        private int _100billsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {

        }
    }
}
