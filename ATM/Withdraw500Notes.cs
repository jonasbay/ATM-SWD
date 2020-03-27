﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Withdraw500Notes : IWithdraw
    {
        private IWithdraw _nextInChain;
        private int _500billsCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            _nextInChain = c;
        }

        public void Withdraw(Amount request)
        {
            if (request.amountLeft_ > 500)
            {
                while (request.amountLeft_ > 500)
                {
                    _500billsCount++;
                    request.amountLeft_ -= 500;
                }

                Console.WriteLine("You have withdrawed " + _500billsCount + "x 500 dollar bills.");
                Console.WriteLine("Remaining amount: " + request.amountLeft_);

                _nextInChain.Withdraw(request);
            }
            else
                _nextInChain.Withdraw(request);
        }
    }
}