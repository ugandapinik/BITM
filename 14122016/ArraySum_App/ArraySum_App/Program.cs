using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Limit Number ");
            int limit=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Numbers ");
            //int num = Convert.ToInt32(Console.ReadLine());


            int[] number = new int[limit];

            for (int i = 0; i < number.Length; i++)
            {
               number[i]=Convert.ToInt32(Console.ReadLine());
               sum += number[i];
            }
            Console.WriteLine("=================");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    //Console.WriteLine(number[i]);
            //    sum += number[i];
            //}
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
