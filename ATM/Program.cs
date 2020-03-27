using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountToWithdraw;
            var money = new Amount(570);

            Console.WriteLine("Enter an amount to withdraw: ");
            amountToWithdraw = Convert.ToDouble(Console.ReadLine());

            var hundreddollarbills = new Amount(amountToWithdraw);

            IWithdraw chainlinkHead = new Withdraw500Notes();
            IWithdraw chainlink1 = new Withdraw100Notes();
            IWithdraw chainlink2 = new Withdraw50Notes();
            IWithdraw chainlink3 = new Withdraw20Coins();
            IWithdraw chainlink4 = new Withdraw10Coins();
            IWithdraw chainlink5 = new Withdraw5Coins();
            IWithdraw chainlink6 = new Withdraw2Coins();
            IWithdraw chainlink7 = new Withdraw1Coins();
            IWithdraw chainlink8 = new Withdraw50Ears();

            chainlinkHead.SetNextWithdrawChain(chainlink1);
            chainlink1.SetNextWithdrawChain(chainlink2);
            chainlink2.SetNextWithdrawChain(chainlink3);
            chainlink3.SetNextWithdrawChain(chainlink4);
            chainlink4.SetNextWithdrawChain(chainlink5);
            chainlink5.SetNextWithdrawChain(chainlink6);
            chainlink6.SetNextWithdrawChain(chainlink7);
            chainlink7.SetNextWithdrawChain(chainlink8);

            chainlinkHead.Withdraw(money);
            chainlinkHead.Withdraw(hundreddollarbills);
            Console.WriteLine("Total amount withdrawn: " + amountToWithdraw);

        }
    }
}
