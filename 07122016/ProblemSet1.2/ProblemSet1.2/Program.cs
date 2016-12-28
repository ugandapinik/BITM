using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1._2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Even numbers between 1 and 100: ");
            for(int i=1;i<=100;i++)
                if (i%2 == 0)
                {
                    Console.WriteLine((i));
                }
            Console.ReadKey();
        }
    }
}
