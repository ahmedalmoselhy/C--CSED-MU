using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("Enter a number (0-999): ");
            int number;
            number = int.Parse(Console.ReadLine());
            string words = "";
            if (number == 0)
            {
                words = "Zero";
                goto print;
            }
            else if (number > 999 || number < 0)
            {
                Console.WriteLine("Value not available, Try between 0-999");
                goto start;
            }
            else
            {
                if ((number / 100) > 0)
                {
                    string[] hunda = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                    int hun = number / 100;
                    string hund = hunda[hun - 1];
                    words += hund + " hundred ";
                    number %= 100;
                }

                if (number > 0)
                {
                    if (words != "")
                        words += "and ";

                    var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                    if (number < 20)
                        words += unitsMap[number];
                    else
                    {
                        words += tensMap[number / 10];
                        if ((number % 10) > 0)
                            words += "-" + unitsMap[number % 10];
                    }
                }
            }
        print:
            Console.WriteLine(words);
            Console.Read();
        }
    }
}