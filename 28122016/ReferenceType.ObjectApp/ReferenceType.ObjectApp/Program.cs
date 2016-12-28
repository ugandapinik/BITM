using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType.ObjectApp {
    class Program {
        static void Main(string[] args) {

            Address address1 = new Address();
            address1.HouseNo = "6";
            address1.RoadNo = "9";
            address1.Thana = "Dhaka";
            address1.District = "Dhaka";

            Person person1 = new Person("FirstName", "MiddleName", "LastName",address1);

            person1.PersonAddress = address1;

           
            person1.PersonAddress.Thana = "Tangail";

            Console.WriteLine(person1.GetAddress());
            Console.ReadKey();
        }
    }
}
