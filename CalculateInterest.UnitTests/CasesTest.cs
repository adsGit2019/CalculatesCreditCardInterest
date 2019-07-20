using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateInterest;
using CalculeInterest;


namespace CalculateInterest.UnitTests
{
    [TestClass]
    public class CasesTest
    {
        [TestMethod]
        public void Case1_WhenCalled_ReturnTotalInterestOn1WalletFor1PersonWith3Card()
        {
            var person = new Person();
            var wallet = new Wallet();
            var visacard = new VisaCard();
            wallet.AddCardToWallet(visacard);
            var mastercard = new MasterCard();
            wallet.AddCardToWallet(mastercard);
            var discovercard = new DiscoverCard();
            wallet.AddCardToWallet(discovercard);
            person.AddWalletToPerson(wallet);


            var result = person.TotalInterest();


            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Case2_WhenCalled_ReturnTotalInterestOn2WalletFor1PersonWith3Card()
        {
            var person = new Person();
            var wallet1 = new Wallet();
            var visacard = new VisaCard();
            wallet1.AddCardToWallet(visacard);
            var discovercard = new DiscoverCard();
            wallet1.AddCardToWallet(discovercard);
            person.AddWalletToPerson(wallet1);

            var wallet2 = new Wallet();
            var mastercard = new MasterCard();
            wallet2.AddCardToWallet(mastercard);
            person.AddWalletToPerson(wallet2);


            var result = person.TotalInterest();


            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Case3_WhenCalled_ReturnTotalInterestOn2WalletFor2PersonWith2CardEachOne()
        {
            var person1 = new Person();
            var wallet1 = new Wallet();
            var mastercard = new MasterCard();
            wallet1.AddCardToWallet(mastercard);
            var visacard = new VisaCard();
            wallet1.AddCardToWallet(visacard);
            person1.AddWalletToPerson(wallet1);

            var person2 = new Person();
            var wallet2 = new Wallet();
            var visacard2 = new VisaCard();
            wallet2.AddCardToWallet(visacard2);
            var mastercard2 = new MasterCard();
            wallet2.AddCardToWallet(mastercard2);
            person2.AddWalletToPerson(wallet2);


            var resultforperson1 = person1.TotalInterest();
            var resultforperson2 = person2.TotalInterest();


            Assert.AreEqual(15, resultforperson1);
            Assert.AreEqual(15, resultforperson2);

        }
    }
}
