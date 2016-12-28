using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_FORApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number ");
            int number = Convert.ToInt32(Console.ReadLine());

            //if (number%2 == 0)
            //{
            //    Console.WriteLine(number+" is even");
            //}
            //else
            //{
            //    Console.WriteLine(number+" is odd");
            //}
            //for(int i=0;i<=number;i++)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i <= number; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i+" is even");
                }
                else
                {
                    Console.WriteLine(i+" is odd");
                }
            }
            Console.ReadKey();
        }
    }
}
