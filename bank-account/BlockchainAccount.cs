using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    public class BlockchainAccount : Account
    {
        public string blockchainName;
        public string publicAddress;

        public BlockchainAccount(string owner, decimal balance, string blockchainname, string publicaddress) : base(owner, balance)
        {
            this.blockchainName = blockchainname;
            this.publicAddress = publicaddress;
        }

        public override decimal GetBalance()
        {
            throw new NotImplementedException();
        }
    }
}
