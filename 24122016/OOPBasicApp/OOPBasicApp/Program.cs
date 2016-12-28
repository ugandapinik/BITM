using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp {
    class Program {
        static void Main(string[] args) {
            Person aPerson = new Person();
            aPerson.firstName = "Firstname";
            aPerson.middleName = "Middlename";
            aPerson.lastName = "Lastname";

            string fullName = aPerson.GetFullName();
            string reverseName = aPerson.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine();


            Person anotherPerson = new Person();
            anotherPerson.firstName = "Sumon";
            anotherPerson.middleName = "";
            anotherPerson.lastName = "Moulik";

            fullName = anotherPerson.GetFullName();
            reverseName = anotherPerson.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.ReadKey();

        }
    }
}
