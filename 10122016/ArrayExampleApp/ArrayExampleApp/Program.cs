using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleApp {
    class Program {
        static void Main(string[] args) {
            //int[] numbers=new int[5];
            //numbers[0] = 55;
            //numbers[1] = 65;
            //numbers[2] = 30;
            //numbers[3] = 20;
            //numbers[4] = 35;
        
            ////Console.WriteLine(numbers[3]);
            //Console.WriteLine("Before sorting....");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(i+"=>"+numbers[i]);
            //}

            //Console.WriteLine("After sorting....");

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(i+"=> "+numbers[i]);
            //}

            //int[] another=new int[]{45,32,58,25};

            //Console.WriteLine("Before sorting....");
            //for (int i = 0; i < another.Length; i++) {
            //    Console.WriteLine(i + "=>" + another[i]);
            //}

            //Console.WriteLine("After sorting....");

            //Array.Sort(another);
            //for (int i = 0; i < another.Length; i++) {
            //    Console.WriteLine(i + "=> " + another[i]);
            //}


            Console.WriteLine("Enter array size..");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] myarray = new int[a];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] =Convert.ToInt32(Console.ReadLine());
            }

            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine(myarray[i]);
            //}
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
