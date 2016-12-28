using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1._3 {
    class Program {
        static void Main(string[] args) {
            int sum = 0;
            for(int i=0;i<1000;i++)
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            Console.WriteLine("Sum of all multiples of 3 or 5 bellow 1000 is: "+sum);
            Console.ReadKey();
        }
    }
}
