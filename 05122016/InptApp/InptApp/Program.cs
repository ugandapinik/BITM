using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InptApp
{
    class Program
    {
        static void Main(string[] args){


            //input firstnumber
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            //input firstnumber
            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Result
            int result = num1 + num2;

            Console.WriteLine("Result is: " + result);



        }
    }
}
