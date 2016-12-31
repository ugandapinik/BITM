using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bank Account System.");
            SavingAccount savingAccount1 = new SavingAccount();
            savingAccount1.AccountNumber = "SV-101";
            savingAccount1.CustomerName = "Sakib Khan";
            Console.WriteLine(savingAccount1.Deposit(1000));
            Console.WriteLine(savingAccount1.Withdraw(1500));
            Console.WriteLine(savingAccount1.Balance);


            Console.WriteLine("-------------------------------------");

            CheckingAccount checkingAccount1 = new CheckingAccount();
            checkingAccount1.AccountNumber = "CK-120";
            checkingAccount1.CustomerName = "Sarif Khan";
            Console.WriteLine(checkingAccount1.Deposit(100));
            Console.WriteLine(checkingAccount1.Withdraw(40000));
            Console.WriteLine(checkingAccount1.Balance);

            

        }
    }
}
