using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1._1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the lower value: ");
            int lowervalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper value: ");
            int uppervalue = Convert.ToInt32(Console.ReadLine());

            for (int i = lowervalue; i <= uppervalue; i++) {

                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
