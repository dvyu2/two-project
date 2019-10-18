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

        public BlockchainAccount(string o, decimal b, string n, string p) : base(o, b)
        {
            this.blockchainName = n;
            this.publicAddress = p;
        }
    }
}
