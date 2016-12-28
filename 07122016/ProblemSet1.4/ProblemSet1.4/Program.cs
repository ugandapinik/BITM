using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1._4 {
    class Program {
        static void Main(string[] args)
        {
            int sumSqr = 0;
            int sum = 0;
            int sumRes = 0;

            for (int i = 1; i <= 100; i++)
            {
               sumSqr += Convert.ToInt32(Math.Pow(i,2));
                sum += i;
                //sumRes = sum * sum;
                
            }
            sumRes = Convert.ToInt32(Math.Pow(sum, 2));
            Console.WriteLine(sumSqr);
            Console.WriteLine(sumRes);
            int diff = sumRes - sumSqr;
            Console.WriteLine("Difference is :" +diff);

            Console.ReadKey();
        }
    }
}
