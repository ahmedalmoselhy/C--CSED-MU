using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write("Enter A Word : ");
            word = Console.ReadLine();

            int x = 0;

            for (x = 0; x < word.Length; x++)
            {
                Console.Write(word[word.Length - 1 - x]);

            }
            Console.WriteLine("");
        }
    }
}