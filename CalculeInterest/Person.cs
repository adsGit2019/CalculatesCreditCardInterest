using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeInterest
{
    public class Person
    {
        private List<Wallet> Wallets;

        public Person()
        {
            Wallets = new List<Wallet>();
        }

        public void AddWalletToPerson(Wallet wallettoadd)
        {
            Wallets.Add(wallettoadd);
        }

        public decimal TotalInterest()
        {
            return Wallets.Sum(w => w.TotalInterestOnWallet()); ;
        }

    }
}
