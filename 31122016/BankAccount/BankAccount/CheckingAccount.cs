using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class CheckingAccount : BankAccount{

        public string ServiceCharge { get; set; }

        public override string Withdraw(double amount)
        {
            //if ammount is less than 10000
            //then user caanot withdraw
            if (amount >= 1000)
            {
                return "You are not Allowed to Withdraw more than 10000 TK";
            }


            return base.Withdraw(amount);
        }
    }
}
