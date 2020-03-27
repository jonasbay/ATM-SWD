using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var hundreddollarbills = new Amount(550);

            IWithdraw chainlinkHead = new Withdraw100Note();
            IWithdraw chainlink1 = new Withdraw50Bills();

            chainlinkHead.SetNextWithdrawChain(chainlink1);


            chainlinkHead.Withdraw(hundreddollarbills);
        }
    }
}
