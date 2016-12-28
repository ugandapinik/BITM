using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CT.BankAccountTransactionWebFormApp {
    [Serializable]
    public class Account {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }

        private decimal balance;

        public decimal Balance {
            get { return balance; }
            set { balance = value; }
        }


        public void DepositAmount(decimal Amount) {
            Balance = Balance + Amount;
        }

        public void WithdrawAmount(decimal Amount) {
            Balance = Balance - Amount;
        }

    }
}