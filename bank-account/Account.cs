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
        public string name;

        public Account(string o, decimal b, string n)
        {
            this.owner = o;
            this.balance = b;
            this.name = n;
        }
    }
}
