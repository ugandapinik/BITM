using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bank Account System.");

            SavingAccount savingAccount1 = new SavingAccount("SV-101", "Sakib Khan", 1000);


            Console.WriteLine("-------------------------------------");

            CheckingAccount checkingAccount1 = new CheckingAccount("CK - 120", "Sarif Khan", 500);


            //cannot create the object
            //BankAccount bank = new BankAccount();
            savingAccount1.Transfer("1", "2", 100);


        }
    }
}
