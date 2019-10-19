using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    public class BankAccount: Account
    {
        public string bankName;
        public string cardNumber;

        public BankAccount(string o, decimal b, string n, string c) : base(o, b)
        {
            this.bankName = n;
            this.cardNumber = c;

        }
    }
}
