using System;
using Banking.Exceptions;

namespace Banking {
    class Program {
        static void Main(string[] args) {

            //var sav1 = new SavingsComposition(); Used to print Savings Composition

            //Turn Savings into Inhertance using Account and Print on first line below
            var sav1 = new SavingsInheritance();
            sav1.Deposit(50);
            sav1.Withdrawal(30);
            //doing exception using try and catch(how you handle/deal with exception) lines 14 - 21
            try {
                //sav1.Withdrawal(50);
                sav1.Withdrawal(-10);
                sav1.Withdrawal(-10);
            } catch (AmountMustBePositiveException ambpex) {
                Console.WriteLine(ambpex.Message);
            
            } catch (InsufficientFundsException ifex) {
                Console.WriteLine(ifex.Message);
                return;
            }
            //will end our program at the end of return at line 18

            sav1.Deposit(100);
            sav1.Withdrawal(20);

            Console.WriteLine($"Savings balance is {sav1.Balance}");
            //Paying Interest 
            sav1.PayInterest(3);
           Console.WriteLine($"Savings balance is {sav1.Balance}");

            // calculation of interest
            //var interest = sav1.Interest(3);
               // Console.WriteLine($"Interest Amount is {sav1.Interest(3)}");
            


           /* var acct1 = new Account("Acct101", "Andrea's Account");

            Console.WriteLine ($"Account {acct1.AccountNumber} balance is {acct1. Balance}");

            acct1.Deposit(200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");

            acct1.Withdrawal(30);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");

            acct1.Withdrawal(230);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");

            acct1.Deposit(-200);
            acct1.Withdrawal(-200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
           */
        }
    }
}  
           
