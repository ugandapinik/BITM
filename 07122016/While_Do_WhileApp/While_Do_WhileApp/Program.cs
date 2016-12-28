using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Do_WhileApp {
    class Program {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 10) {
                Console.WriteLine(number);
                number++;
            }

            //do
            //{
            //    Console.WriteLine(number);
            //    number++;
            //} while (number<10);
            Console.ReadLine();
        }
    }
}
