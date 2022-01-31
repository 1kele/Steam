using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Wallet
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    balance = 0;
                }
                balance = value;
            }
        }

        public bool Check(decimal price)
        {
            return price <= Balance;
        }
    }
}
