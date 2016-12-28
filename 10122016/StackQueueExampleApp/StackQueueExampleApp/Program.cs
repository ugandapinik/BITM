using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueExampleApp {
    class Program {
        static void Main(string[] args) {
            Stack<int> stackInt = new Stack<int>();
            stackInt.Push(40);
            stackInt.Push(90);
            stackInt.Push(10);
            Console.WriteLine("==========Stack Original========");

            foreach (int number in stackInt) {
                Console.WriteLine(number);
            }
            Console.WriteLine("==========Stack afetr pop and push========");

            stackInt.Pop();
            stackInt.Push(75);
            foreach (int number in stackInt) {
                Console.WriteLine(number);
            }
            Console.WriteLine("==========Stack Peek========");
            Console.WriteLine(stackInt.Peek());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========Queue Original========");
            Queue<int> queueint=new Queue<int>();
            queueint.Enqueue(25);
            queueint.Enqueue(34);
            queueint.Enqueue(27);

            foreach (int number in queueint) {
                Console.WriteLine(number);
            }


            Console.WriteLine("==========Queue afetr Dequeue and Enqueue========");
            queueint.Dequeue();
            queueint.Enqueue(54);
            queueint.Enqueue(24);
            queueint.Dequeue();
            foreach (int number in queueint) {
                Console.WriteLine(number);
            }

            Console.WriteLine("==========Queue Peek========");
            Console.WriteLine(queueint.Peek());

            Console.ReadKey();
        }
    }
}
