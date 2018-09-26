using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNamesAndDegree
{

    class Program
    {
        static void Main(string[] args)
        {
            // Define main variables
            int n = 0;
            Console.Write("Enter The Number of Students : ");
            n = int.Parse(Console.ReadLine());

            string[] s_names = new string[n];
            int[] s_degrees = new int[n];
            int i = 0;

            // Adding Values
            for (i = 0; i < n; i++)
            {
                s_names[i] = add_names();
                s_degrees[i] = add_degrees();
            }

            // Main Program
            get:
            // Text To appear
            Console.WriteLine("***********");
            Console.WriteLine("Please select an option :");
            Console.WriteLine("===========================");
            Console.WriteLine("Search A Student's Degree : 1");
            Console.WriteLine("Get The Highest Score : 2");
            Console.WriteLine("Change A Student's Name : 3");
            Console.WriteLine("Exit Program : 0");
            Console.WriteLine("=========================================");

            //Selection
            string x;
            Console.Write("Enter Your Choice : ");
            x = Console.ReadLine();

            //Cases Variables
            int degree_o = 0;
            int degree = 0;
            string name;
            int name_o;

            ///////////////////////////////////////////////////////////////////////////////
            //Cases
            if (x == "1")
            { // First Case
                Console.Write("Enter The Name : ");
                name = Console.ReadLine();
                degree_o = search(name, s_names);
                degree = s_degrees[degree_o];

                Console.WriteLine("His/Her Degree = " + degree);
                goto get;
            } /////////////////////////////////////////
            else if (x == "2")
            { // Second Case
                degree_o = high(s_degrees);
                degree = s_degrees[degree_o];
                name = s_names[degree_o];


                Console.WriteLine("The Highest Student : " + name);
                Console.WriteLine("His/Her Degree : " + degree);

                goto get;
            } //////////////////////////////////////////
            else if (x == "3")
            { // Third Case
                Console.Write("Enter The Old Name : ");
                name = Console.ReadLine();

                name_o = search(name, s_names);


                s_names[name_o] = change_name();
                Console.WriteLine("Name Changed To : " + s_names[name_o]);
                goto get;
            }
            else if (x == "0")
            { // Exit Case
                goto end;
            } // Error Check
            else
            {
                Console.WriteLine("ERROR, WRONG INPUT, TRY AGAIN");
                goto get;
            }

            end:
            Console.WriteLine("GOODBYE!");
        }

        // Functions to Add Values
        public static string add_names()
        {
            string name = "NULL";
            Console.Write("Enter The Student Name : ");
            name = Console.ReadLine();
            return name;
        }

        public static int add_degrees()
        {
            int degree;
            degree = 0;

            Console.Write("Enter The Student Degree : ");
            degree = int.Parse(Console.ReadLine());
            return degree;
        }

        // First Case Function, Used also in Function 3 To Get The Order of the name.
        public static int search(string name, params string[] m)
        {
            int ord = 0;
            int i = 0;
            for (i = 0; i < m.Length; i++)
            {
                if (name == m[i])
                {
                    ord = i;
                }
            }
            return ord;
        }

        // Second Case Function
        public static int high(params int[] a)
        {
            int ord = 0, max = a[0];
            int m = 0;
            for (ord = 0; ord < a.Length; ord++)
            {
                if (a[ord] > max)
                {
                    max = a[ord];
                    m = ord;
                }
            }

            return m;
        }

        //Third Case Function
        public static string change_name()
        {
            string name = "NULL";
            Console.Write("Enter The New Name : ");
            name = Console.ReadLine();

            return name;
        }
    }
}