using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var hundreddollarbills = new Amount(570);

            IWithdraw chainlinkHead = new Withdraw100Note();
            IWithdraw chainlink1 = new Withdraw50Bills();
            IWithdraw chainlink2 = new Withdraw20Coins();

            chainlinkHead.SetNextWithdrawChain(chainlink1);
            chainlink1.SetNextWithdrawChain(chainlink2);

            chainlinkHead.Withdraw(hundreddollarbills);
        }
    }
}
