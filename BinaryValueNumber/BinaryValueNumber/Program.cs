using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryValueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter A Number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("------");
            Console.WriteLine("You Entered : " + number);
            string Bnumber = Convert.ToString(number, 2);

            Console.Write("Enter a Bit Number : ");
            int x = int.Parse(Console.ReadLine());

            if (x > Bnumber.Length)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(Bnumber[x - 1]);
            }
        }
    }
}