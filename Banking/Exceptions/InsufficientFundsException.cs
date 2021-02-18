using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions {
    class InsufficientFundsException : Exception {

        public decimal AccountBalance { get; set; }
        public decimal AmountToWithdrawal { get; set; }
        //added properties to our exception

        public InsufficientFundsException (decimal balance, decimal amount)
            :base($"Current Balance is {balance}, withdraw amount is {amount}") {
            AccountBalance = balance;
            AmountToWithdrawal = amount;
            // added another constructor with two parameters after we created the two properties
        }
        public InsufficientFundsException():
            base() { }
        public InsufficientFundsException(string Message) :
            base() { }
        public InsufficientFundsException(string Message, Exception InnerException) :
            base(Message, InnerException) { }
        //must have all three of these constructors for an exception slide 190


    }
}
