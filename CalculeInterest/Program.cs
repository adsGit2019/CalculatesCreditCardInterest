using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeInterest
{

    class Program
    {
        static void Main(string[] args)
        {
            ////// CASE 1 //////
            var person = new Person();  
            var wallet = new Wallet();

            var creditcard1 = new VisaCard();
            var visaCardInterest = creditcard1.CalculateInterestByMonth();
            wallet.AddCardToWallet(creditcard1);
            var creditcard2 = new MasterCard();
            var mcCardInterest = creditcard2.CalculateInterestByMonth();
            wallet.AddCardToWallet(creditcard2);
            var creditcard3 = new DiscoverCard();
            var DiscCardInterest = creditcard3.CalculateInterestByMonth();
            wallet.AddCardToWallet(creditcard3);

            person.AddWalletToPerson(wallet);

            var totalInteWallet = wallet.TotalInterestOnWallet();
           
            var totalIntePerson = person.TotalInterest();

            Console.WriteLine("////  CASE 1 ////");
            Console.WriteLine("Visa Card interest:" + "$" + visaCardInterest.ToString());
            Console.WriteLine("Master Card interest:" + "$" + mcCardInterest.ToString());
            Console.WriteLine("Discover Card interest:" + "$" + DiscCardInterest.ToString());
            Console.WriteLine("Total interest acumulated in the wallet:" + "$" + totalInteWallet.ToString());
            Console.WriteLine("Total interest to pay for the person:" + "$" + totalIntePerson.ToString());
            Console.WriteLine("");


            ////// CASE 2 //////
            var c2person = new Person();
            var c2wallet1 = new Wallet();

            var c2creditcard1 = new VisaCard();
            var c2visaCardInterest1 = c2creditcard1.CalculateInterestByMonth();
            c2wallet1.AddCardToWallet(c2creditcard1);

            var c2creditcard2 = new DiscoverCard();
            var c2DiscCardInterest2 = c2creditcard2.CalculateInterestByMonth();
            c2wallet1.AddCardToWallet(c2creditcard2);
            c2person.AddWalletToPerson(c2wallet1);
            var interestInWallet1 = c2wallet1.TotalInterestOnWallet();

            var c2wallet2 = new Wallet();

            var c2creditcard3 = new MasterCard();
            var c2MasterCardInterest = c2creditcard3.CalculateInterestByMonth();
            c2wallet2.AddCardToWallet(c2creditcard3);
            var interestInWallet2 = c2wallet2.TotalInterestOnWallet();
            c2person.AddWalletToPerson(c2wallet2);

            var totalIntePersonIn2Wallet = c2person.TotalInterest();   

            Console.WriteLine("////  CASE 2 ////");
            Console.WriteLine("Visa Card interest:" + "$" + c2visaCardInterest1.ToString());
            Console.WriteLine("Discover Card interest:" + "$" + c2DiscCardInterest2.ToString());
            Console.WriteLine("Total interest acumulated in the wallet 1:" + "$" + interestInWallet1.ToString());
            Console.WriteLine("Master Card interest:" + "$" + c2MasterCardInterest.ToString());
            Console.WriteLine("Total interest acumulated in the wallet 2:" + "$" + interestInWallet2.ToString());
            Console.WriteLine("Total interest acumulated in the wallets:" + "$" + totalIntePersonIn2Wallet.ToString());
            Console.WriteLine("Total interest to pay for the person:" + "$" + totalIntePersonIn2Wallet.ToString());
            Console.WriteLine("");


            ///CASE 3////
            var c3person1 = new Person();
            var c3wallet1 = new Wallet();

            var c3creditcard1 = new MasterCard();
            var c3masterCardInterest1 = c3creditcard1.CalculateInterestByMonth();
            c3wallet1.AddCardToWallet(c3creditcard1);

            var c3creditcard2 = new VisaCard();
            var c3visaCardInterest2 = c3creditcard2.CalculateInterestByMonth();
            c3wallet1.AddCardToWallet(c3creditcard2);
            var interestInWalletPerson1 = c3wallet1.TotalInterestOnWallet();

            c3person1.AddWalletToPerson(c3wallet1);
            var totalIntePerson1 = c3person1.TotalInterest();

            //
            var c3person2 = new Person();
            var c3wallet2 = new Wallet();

            var c3creditcard3 = new VisaCard();
            var c3visaCardInterest3 = c3creditcard3.CalculateInterestByMonth();
            c3wallet2.AddCardToWallet(c3creditcard3);

            var c3creditcard4 = new MasterCard();
            var c3masterCardInterest4 = c3creditcard4.CalculateInterestByMonth();
            c3wallet2.AddCardToWallet(c3creditcard4);
            var interestInWalletPerson2 = c3wallet2.TotalInterestOnWallet();

            c3person2.AddWalletToPerson(c3wallet2);

            var totalIntePerson2 = c3person2.TotalInterest();

            Console.WriteLine("////  CASE 3 ////");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Master Card interest:" + "$" + c3masterCardInterest1.ToString());
            Console.WriteLine("Visa Card interest:" + "$" + c3visaCardInterest2.ToString());
            Console.WriteLine("Total interest acumulated in the wallet:" + "$" + interestInWalletPerson1.ToString());
            Console.WriteLine("Total interest to pay:" + "$" + totalIntePerson1.ToString());
            Console.WriteLine("Person 2:");
            Console.WriteLine("Visa Card interest:" + "$" + c3visaCardInterest3.ToString());
            Console.WriteLine("Master Card interest:" + "$" + c3masterCardInterest4.ToString());
            Console.WriteLine("Total interest acumulated in the wallet:" + "$" + interestInWalletPerson2.ToString());
            Console.WriteLine("Total interest to pay:" + "$" + totalIntePerson2.ToString());
            Console.ReadLine();

        }


    }

    

}
