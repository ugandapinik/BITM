using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHidingPropertyApp {
    class Person {
        private string firstName;
        private string middleName;
        private string lastName;

        //public  string FirstName { set; get; }
        //public string MiddleName { get; set; }
        //public string LastName { get; set; }



        #region
        /* One way
        public string FirstName {
            set {
                if (value.Length > 2)
                    firstName = value;
            }
            get { return firstName; }
        }

        public string MiddleName {
            set { middleName = value; }
            get { return middleName; }
        }

        public string LastNAme {
            set { middleName = value; }
            get { return middleName; }
        }
        */
        #endregion

        #region

        public string FirstName {
            get { return firstName; }
            set {
                if (value.Length > 2)
                    firstName = value;
            }
        }
        public string MiddleName {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName {
            set { lastName = value; }
            get { return lastName; }
        }

        #endregion

        public string GetFullName() {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

    }
}
