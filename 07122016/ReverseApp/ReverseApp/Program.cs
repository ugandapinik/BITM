using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseApp {
    class Program {
        static void Main(string[] args)
        {
            string a = "1234";
            char[] narray = a.ToCharArray();
            Array.Reverse(narray);
            Console.WriteLine("Input:"+a);
            Console.WriteLine(narray);
            Console.ReadKey();
        }
    }
}
