using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber {
    class Program {
        static void Main(string[] args) {
            bool isprime = true;
            Console.WriteLine("Prime numbers between 1 and 100:");

            for (int i = 2; i <= 100; i++) {
                for (int j = 2; j < 100; j++) {
                    if (i != j && i % j == 0) {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                    Console.WriteLine(i);
                isprime = true;
            }
            Console.ReadKey();
        }
    }
}
