using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Overridding.ChainingApp {
    class Person {
        public string firstName;
        public string middleName;
        public string lastName;
        public string personId;


        public Person(string firstName, string middleName, string lastName)
            : this(firstName, lastName) {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName) :this(){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person() {

        }


        public string  GetId()
        {
            string id = personId;
            return id;
        }
        public string GetFullName() {
            string fullName = "";
            if (middleName != null) {
                fullName = firstName + " " + middleName + " " + lastName;
            } else {
                fullName = firstName + " " + lastName;
            }
            return fullName;
        }

        public string GetReverseName() {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverseName = string.Empty;
            for (int i = cArray.Length - 1; i > -1; i--) {
                reverseName += cArray[i];
            }
            return reverseName;
        }
    }
}
