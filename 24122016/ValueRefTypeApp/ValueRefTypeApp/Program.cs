using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypeApp {
    class Program {
        static void Main(string[] args) {
            Person aPerson = new Person();
            aPerson.firstName = "Firstname";
            aPerson.middleName = "Middlename";
            aPerson.lastName = "Lastname";

            Person anotherPerson = aPerson;
            anotherPerson.middleName = "";
            Change(anotherPerson);
            Console.WriteLine(aPerson.GetFullName());

            Console.ReadKey();
        }

        private static void Change(Person person) {
            person.middleName = "MidName";
        }
    }
}
