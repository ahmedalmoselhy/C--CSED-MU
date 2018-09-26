using System;

namespace NumbersUndividableBy3or7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 1, i, j;

            Console.Write("Enter The Limit: ");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                i = x % 3;
                j = x % 7;

                if (i != 0 && j != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}