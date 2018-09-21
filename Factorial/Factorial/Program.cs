using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("Enter The First Number : ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter The Second Number : ");
            int n = int.Parse(Console.ReadLine());

            if (k < 1 || k > n)
            {
                Console.WriteLine("Please Try Again");
                goto start;
            }

            double res;
            int fn = 1, fk = 1;
            for (int i = n; i > 0; i--)
            {
                fn *= i;
            }
            for (int i = k; i > 0; i--)
            {
                fk *= i;
            }
            res = fn / fk;
            Console.WriteLine(res);
        }
    }
}