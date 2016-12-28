using System;

namespace InputApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World");
           // Console.WriteLine("Enter Your Name");
           // string name = Console.ReadLine();
           // Console.WriteLine("Enter Your Phone number");
           // int phoneNo =Convert.ToInt32(Console.ReadLine());
           //// Console.Write(name+", his/her Phone no :"+phoneNo);
           // Console.Write("Name is "+"'"+name+"'"+" And Phone No is "+phoneNo);

            //int a = 12;
            //int b = 2;
            //int sum = Convert.ToInt32(a + b);
            //Console.WriteLine("Sum is "+sum);
            //int substract = Convert.ToInt32(a-b);
            //Console.WriteLine("Substraction is :"+substract);

            Console.WriteLine("Enter first value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = Convert.ToInt32(a + b);
            Console.WriteLine("Sum is: "+sum);

            //Console

            Console.ReadKey();
        }
    }
}
