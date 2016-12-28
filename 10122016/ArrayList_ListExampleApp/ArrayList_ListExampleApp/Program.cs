using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_ListExampleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ArrayList........");
            ArrayList numberlist = new ArrayList();
            numberlist.Add(52);
            numberlist.Add(34);
            numberlist.Add(42);

            foreach (int number in numberlist) {
                Console.WriteLine(number);
            }

            Console.WriteLine("List........");

            List<int> numbers = new List<int>();
            //numbers.Add(58);
            //numbers.Add(26);
            //numbers.Add(25);
            //numbers.Add(35);
            //numbers.Add(55);

            //numbers.Remove(58);
            //numbers.RemoveAt(3);
            //numbers[1] = 89;
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            int enumber = 0;
            do
            {
                enumber = Convert.ToInt32(Console.ReadLine());
                numbers.Add(enumber);
            } while (enumber < 0);
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
