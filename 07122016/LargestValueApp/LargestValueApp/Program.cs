using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestValueApp {
    class Program {
        private static void Main(string[] args) {
            int[] myarray = new int[3];

            Console.WriteLine("Enter the array elements ");
            for (int i = 0; i < 3; i++) {
                myarray[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            int smallest = myarray[0];
            for (int i = 0; i < myarray.Length; i++) {
                if (myarray[i] < smallest)
                    smallest = myarray[i];
            }
           
            int largest = myarray[2];
            for (int i = 0; i < myarray.Length; i++) {
                if (myarray[i] > largest) {
                    largest = myarray[i];
                }
            }
            Console.WriteLine("Largest value is:"+largest);
            Console.ReadKey();
        }
    }
}
