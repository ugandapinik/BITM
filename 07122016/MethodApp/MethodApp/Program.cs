using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp {
    class Program {
        static void Main(string[] args)
        {

            int a = Add(20, 10);
            Console.WriteLine(a);
            int b = Substract(20, 10);
            Console.WriteLine(b);
            Console.ReadLine();
        }

       static int Add(int firstNumber, int secondNumber)
       {
           return Result(firstNumber, secondNumber);
       }

        private static int Result(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int Substract(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }
    }
}
