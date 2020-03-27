using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Amount(570);

            IWithdraw chainlinkHead = new Withdraw500Notes();
            IWithdraw chainlink1 = new Withdraw100Notes();
            //IWithdraw chainlink2 = new Withdraw50Notes();
            IWithdraw chainlink2 = new Withdraw20Coins();

            chainlinkHead.SetNextWithdrawChain(chainlink1);
            chainlink1.SetNextWithdrawChain(chainlink2);
            //chainlink2.SetNextWithdrawChain(chainlink3);

            chainlinkHead.Withdraw(money);
        }
    }
}
