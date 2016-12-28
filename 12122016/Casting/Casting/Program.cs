using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting {
    class Program {
        static void Main(string[] args)
        {
            short firstNumber = 65;
            long secondNumber = firstNumber;
            short thirdNumber = (short) secondNumber;
            Console.WriteLine(thirdNumber);
            char a = (char) firstNumber;
            Console.WriteLine(a);
            char t = 'B';
            short z = (short) t;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
