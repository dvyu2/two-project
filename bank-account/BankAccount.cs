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

        public BankAccount(string owner, decimal balance, string bankname, string cardnumber) : base(owner, balance)
        {
            this.bankName = bankname;
            this.cardNumber = cardnumber;
        }

        public override decimal GetBalance()
        {
            throw new NotImplementedException();
        }
    }
}
