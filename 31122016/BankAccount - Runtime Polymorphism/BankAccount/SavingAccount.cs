using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class SavingAccount : BankAccount {

        public double InterestAmount { get; set; }

        public SavingAccount(){
        }

        public SavingAccount(string accountNumber, string customerName, double interestAmount) : base(accountNumber, customerName)
        {
            InterestAmount = interestAmount;


        }
        public override string Withdraw(double amount)
        {
            if (amount >= Balance)
            {
                return "Insufficient Balance.";
            }

            return base.Withdraw(amount);
        }

        public override void Transfer(string from, string to, double amount) {
            //throw new NotImplementedException();
            //Todo
        }
    }
}
