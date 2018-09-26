using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex;
            Console.Write("Enter A Hexadecimal Number : ");
            hex = Console.ReadLine();
            decimal des;

            des = Convert.ToInt32(hex, 16);

            Console.WriteLine(des);
        }
    }
}