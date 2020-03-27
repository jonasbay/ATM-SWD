using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public interface IWithdraw
    {
        void SetNextWithdrawChain(IWithdraw nextInChain);
        void Withdraw(Amount request);
    }
}
