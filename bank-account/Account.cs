using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    public class Account : IAccount
    {
        public string owner;
        public decimal balance;

        public Account(string owner, decimal balance)
        {
            this.owner = owner;
            this.balance = balance;
        }

        public virtual decimal GetBalance()
        {
            retun balance;
        }

        public decimal ShowName()
        {
            return owner;
        }
    }
}
