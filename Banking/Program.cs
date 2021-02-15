using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {

            var acct1 = new Account();
            acct1.AccountNumber = "100";
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

        }
    }
}
