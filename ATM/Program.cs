using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            //Create chainlinks
            IWithdraw chainlinkHead = new Withdraw1000Notes();
            IWithdraw chainlink1 = new Withdraw500Notes();
            IWithdraw chainlink2 = new Withdraw200Notes();
            IWithdraw chainlink3 = new Withdraw100Notes();
            IWithdraw chainlink4 = new Withdraw50Notes();
            IWithdraw chainlink5 = new Withdraw20Coins();
            IWithdraw chainlink6 = new Withdraw10Coins();
            IWithdraw chainlink7 = new Withdraw5Coins();
            IWithdraw chainlink8 = new Withdraw2Coins();
            IWithdraw chainlink9 = new Withdraw1Coins();
            IWithdraw chainlink10 = new Withdraw50Ears();
            IWithdraw chainlinkEnd = new chainEnd();

            //Link chainlinks
            chainlinkHead.SetNextWithdrawChain(chainlink1);
            chainlink1.SetNextWithdrawChain(chainlink2);
            chainlink2.SetNextWithdrawChain(chainlink3);
            chainlink3.SetNextWithdrawChain(chainlink4);
            chainlink4.SetNextWithdrawChain(chainlink5);
            chainlink5.SetNextWithdrawChain(chainlink6);
            chainlink6.SetNextWithdrawChain(chainlink7);
            chainlink7.SetNextWithdrawChain(chainlink8);
            chainlink8.SetNextWithdrawChain(chainlink9);
            chainlink9.SetNextWithdrawChain(chainlink10);
            chainlink10.SetNextWithdrawChain(chainlinkEnd);
            
            bool cont;
            do
            {
                //Request
                Console.WriteLine("Enter an amount to withdraw: ");
                double amountToWithdraw = Convert.ToDouble(Console.ReadLine());
                var money = new Amount(amountToWithdraw);
                chainlinkHead.Withdraw(money);


                while (true)
                {
                    Console.WriteLine("Withdraw more? [y/n]");
                    Console.BackgroundColor = ConsoleColor.Black;
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        cont = true;
                        break;
                    }
                    else if (choice == "n")
                    {
                        cont = false;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                }
            } while (cont);
        }
    }
}
