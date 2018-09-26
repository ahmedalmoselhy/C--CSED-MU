using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Enter A : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter C : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter D : ");
            d = int.Parse(Console.ReadLine());

            int temp1 = bigger(a, b);

            int temp2 = bigger(c, d);

            int big = bigger(temp1, temp2);

            Console.WriteLine("The Bigger is : " + big);
        }
        public static int bigger(int x, int y)
        {
            int z;
            if (x > y)
            {
                z = x;
            }
            else
            {
                z = y;
            }
            return z;
        }
    }
}