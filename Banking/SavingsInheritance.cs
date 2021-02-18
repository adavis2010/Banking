using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    //savings class using inheritance from Account class
    class SavingsInheritance : Account {

        // this was extra and not required for homework but adding interest rate (property)
        public decimal InterestRate { get; set; } = 0.12m;

        //calculate and pay interest (method)
        public void PayInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }

        // default constructor
        public SavingsInheritance() : base() { }

        // passing in Account Number Constructor with two Parameters
        public SavingsInheritance(String AcctNbr, String Desc) : base(AcctNbr, Desc) {
        }
        // passing in Description to Account (additional Constructor)
        public SavingsInheritance(string AcctNbr, decimal IntRate)
            : base(AcctNbr, "New Savings Account"){
            this.InterestRate = IntRate;




            

        }
    };
}
























