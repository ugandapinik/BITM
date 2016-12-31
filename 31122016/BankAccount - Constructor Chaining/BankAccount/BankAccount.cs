using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class BankAccount {

        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, string customerName)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }

        public BankAccount()
        {
            //init balance
            Balance = 0;
        }


        public string Deposit(double amount)
        {
            Balance += amount;
            return "Successfully Deposited.";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Succesfully Withdraw.";
        }

    }
}
