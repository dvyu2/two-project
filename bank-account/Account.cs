using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    public class Account
    {
        public string owner;
        public decimal balance;

        public Account(string o, decimal b)
        {
            this.owner = o;
            this.balance = b;
        }
    }
}
