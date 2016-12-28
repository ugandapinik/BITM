using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType.ObjectApp {
    class Person {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address PersonAddress { get; set; }


        public Person(string firstName, string middleName, string lastName, Address address)
            : this(firstName, middleName, lastName) {

            MiddleName = middleName;
        }
        public Person(string firstName, string middleName, string lastName)
            : this(firstName, lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName)
            : this() {
        }

        public Person() {

        }
        public string GetFulName() {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }
        public string GetAddress() {
            string addres = "House No: " + PersonAddress.HouseNo + ", Road No: " + PersonAddress.RoadNo + ", Thana:" + PersonAddress.Thana + ", District" + PersonAddress.District;
            return addres;
        }
    }
}
