using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw50Notes : IWithdraw
    {

        private IWithdraw nexInChain;
        private int _100noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {

        }
    }
}
