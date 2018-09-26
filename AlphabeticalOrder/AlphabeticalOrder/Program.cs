using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Word : ");
            string inp = Console.ReadLine();

            order(inp);

        }
        public static void order(string word)
        {
            int or = 0;
            int i;
            for (i = 0; i < word.Length; i++)
            {

                if (word[i] == 'a' || word[i] == 'A')
                {
                    or = 1;
                }
                else if (word[i] == 'b' || word[i] == 'B')
                {
                    or = 2;
                }
                else if (word[i] == 'c' || word[i] == 'C')
                {
                    or = 3;
                }
                else if (word[i] == 'd' || word[i] == 'D')
                {
                    or = 4;
                }
                else if (word[i] == 'e' || word[i] == 'E')
                {
                    or = 5;
                }
                else if (word[i] == 'f' || word[i] == 'F')
                {
                    or = 6;
                }
                else if (word[i] == 'g' || word[i] == 'G')
                {
                    or = 7;
                }
                else if (word[i] == 'h' || word[i] == 'H')
                {
                    or = 8;
                }
                else if (word[i] == 'i' || word[i] == 'I')
                {
                    or = 9;
                }
                else if (word[i] == 'j' || word[i] == 'J')
                {
                    or = 10;
                }
                else if (word[i] == 'k' || word[i] == 'K')
                {
                    or = 11;
                }
                else if (word[i] == 'l' || word[i] == 'L')
                {
                    or = 12;
                }
                else if (word[i] == 'm' || word[i] == 'M')
                {
                    or = 13;
                }
                else if (word[i] == 'n' || word[i] == 'N')
                {
                    or = 14;
                }
                else if (word[i] == 'O' || word[i] == 'o')
                {
                    or = 15;
                }
                else if (word[i] == 'p' || word[i] == 'P')
                {
                    or = 16;
                }
                else if (word[i] == 'q' || word[i] == 'Q')
                {
                    or = 17;
                }
                else if (word[i] == 'r' || word[i] == 'R')
                {
                    or = 18;
                }
                else if (word[i] == 's' || word[i] == 'S')
                {
                    or = 19;
                }
                else if (word[i] == 'T' || word[i] == 't')
                {
                    or = 20;
                }
                else if (word[i] == 'u' || word[i] == 'U')
                {
                    or = 21;
                }
                else if (word[i] == 'v' || word[i] == 'V')
                {
                    or = 22;
                }
                else if (word[i] == 'W' || word[i] == 'w')
                {
                    or = 23;
                }
                else if (word[i] == 'x' || word[i] == 'X')
                {
                    or = 24;
                }
                else if (word[i] == 'y' || word[i] == 'Y')
                {
                    or = 25;
                }
                else if (word[i] == 'z' || word[i] == 'Z')
                {
                    or = 26;
                }
                Console.WriteLine(word[i] + " = " + or);
            }

        }
    }
}