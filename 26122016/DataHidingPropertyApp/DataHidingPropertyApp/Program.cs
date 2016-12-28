using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHidingPropertyApp {
    class Program {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            Console.WriteLine("Enter first name:");
            aPerson.FirstName = Console.ReadLine();
            Console.WriteLine("Enter middle name:");
            aPerson.MiddleName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            aPerson.LastName = Console.ReadLine();
            Console.WriteLine(aPerson.GetFullName());
            Console.ReadKey();
        }
    }
}
