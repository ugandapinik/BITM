using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Overridding.ChainingApp {
    class Program {
        static void Main(string[] args) {
            Person aPerson = new Person("Firstname", "Middlename", "Lastname");

            Person anotherPerson = new Person("Sumon", "Moulik");

            Person person3 = new Person();
            {
                person3.personId = "107512";
            }

            Console.WriteLine(aPerson.GetFullName());
            Console.WriteLine();
            Console.WriteLine(anotherPerson.GetFullName());
            Console.WriteLine();
            Console.WriteLine(person3.GetId());

            Console.ReadKey();
        }
    }
}
