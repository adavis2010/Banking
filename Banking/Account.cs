using System;
using System.Collections.Generic;
using System.Text;
using Banking.Exceptions;
    //will cause exceptions to go to Exceptions folder

namespace Banking {
    class Account {
        public string AccountNumber { get; private set; }
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount) {
            if (amount >= 0) {
                Balance += amount;
            }
        }
        public void Withdrawal(decimal amount) {
            if (amount < 0) {
                return;
            }
            if (Balance >= amount) {
                Balance -= amount;

            } else {
                //passing in new values two parameter constructor
                throw new InsufficientFundsException(Balance,amount);
                //causing an exception to occur with throw 
                //Console.WriteLine($"Insufficient Funds!");

            }

        }
        //default constructor
        public Account(): this("DefAcct0", "Default Account Description") { }

        // constructor with two parameters
        public Account(string acctNbr, string desc = "New Account") {
            AccountNumber = acctNbr;
            Description = desc;
        }
    }
}
            
            
            
                


        



    

