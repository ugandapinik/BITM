using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bank Account System.");
            //SavingAccount savingAccount1 = new SavingAccount();
            SavingAccount savingAccount1 = new SavingAccount("SV-101", "Sakib Khan", 1000);
            //savingAccount1.AccountNumber = "SV-101";
            //savingAccount1.CustomerName = "Sakib Khan";
            Console.WriteLine(savingAccount1.Deposit(1000));
            Console.WriteLine(savingAccount1.Withdraw(1500));
            Console.WriteLine(savingAccount1.Balance);


            Console.WriteLine("-------------------------------------");

            CheckingAccount checkingAccount1 = new CheckingAccount("CK - 120", "Sarif Khan", 500);
            Console.WriteLine(checkingAccount1.Deposit(1000));
            Console.WriteLine(checkingAccount1.Withdraw(40000));
            Console.WriteLine(checkingAccount1.Balance);

            

        }
    }
}
