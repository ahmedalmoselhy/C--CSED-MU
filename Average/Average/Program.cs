using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the number of values : ");
            int n = int.Parse(Console.ReadLine());
            double[] num = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Value no " + i + 1 + " : ");
                num[i] = int.Parse(Console.ReadLine());
            }

            double res = avg(num);


            Console.WriteLine(res);
        }
        public static double avg(params double[] x)
        {
            double m = 0;
            double tem = 0;
            for (int j = 0; j < x.Length; j++)
            {
                tem += x[j];
            }
            m = tem / x.Length;
            return m;
        }
    }
}