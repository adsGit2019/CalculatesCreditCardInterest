using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeInterest
{
    public class Wallet
    {
        public List<ICards> Cards;

        public Wallet()
        {
            Cards = new List<ICards>();
        }

        public void AddCardToWallet(ICards creditcard)
        {
            Cards.Add(creditcard);
        }

        public decimal TotalInterestOnWallet()
        {
            return Cards.Sum(c => c.GetInterestCalculated()); ;
        }


    }
}