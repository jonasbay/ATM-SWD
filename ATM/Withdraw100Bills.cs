﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw100Bills : IWithdraw
    {
        private IWithdraw nexInChain;
        private int _100billsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.AmountLeft > 100)
            {
                while (request.AmountLeft > 100)
                {
                    _100billsCount++;
                    request.AmountLeft -= 100;
                }

                Console.WriteLine("You have withdrawed " + _100billsCount + "100 dollar bills.");
                Console.WriteLine("Remaining amount: " + request.AmountLeft);

                nexInChain.Withdraw(request);
            }
            else
                nexInChain.Withdraw(request);
        }
    }
}