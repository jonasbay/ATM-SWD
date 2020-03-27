using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var hundreddollarbills = new Amount(570);

            IWithdraw chainlinkHead = new Withdraw500Notes();
            IWithdraw chainlink1 = new Withdraw100Notes();
            IWithdraw chainlink2 = new Withdraw50Notes();
            IWithdraw chainlink3 = new Withdraw20Coins();

            chainlinkHead.SetNextWithdrawChain(chainlink1);
            chainlink1.SetNextWithdrawChain(chainlink2);

            chainlinkHead.Withdraw(hundreddollarbills);
        }
    }
}
