using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int i, j, k, l;

            Console.Write("Enter A Number : ");
            x = int.Parse(Console.ReadLine());

            if (x == 2 || x == 3 || x == 5 || x == 7)
            {
                Console.WriteLine("It's Primal");

            }
            else
            {
                i = x % 2;
                j = x % 3;
                k = x % 5;
                l = x % 7;


                if (i != 0 && j != 0 && k != 0 && l != 0)
                {
                    Console.WriteLine("It's Primal!");
                }
                else
                {
                    Console.WriteLine("It's NOT Primal");
                }
            }
        }
    }
}