using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class SavingsComposition {

        public decimal InterestRate { get; set; } = 0.12m;

        //Calculate Interest (could change public to private on Interest... in which I did
        private decimal Interest(int months ) {
            return account.Balance * (InterestRate / 12) * months;
        }
        //adding method to deposit interest
        public void PayInterest(int months) {
            var interest = Interest(months);
            Deposit(interest);
        }


        public Account account { get; set; }
        //displaying property (Balance) from account. 
        
        public decimal Balance {
            get { return account.Balance;}
        }

        public void Deposit(decimal amount) {
            account.Deposit(amount);
        }

        public void Withdrawal(decimal amount) {
            account.Withdrawal(amount);
        }


        public SavingsComposition() {
            // adding two parameters..("4","Savings Account"); 
            this.account = new Account("4","Savings Account");       
        }
        
        
    
    
    
    
    
    
    
    }






}
