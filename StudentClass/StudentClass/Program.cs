using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahmed", "ahmed.96@mans.edu.eg", "Civil", "MU", 01234567890);

            Student s2 = new Student("Ahmed");

            Student s3 = new Student("Alaa");

            Student s4 = new Student("Adel", "adel.99@gmail.com", "CS", "MU", 2644660);

            s4.print();

            s1.print();

            s2.print();

            s3.print();

            Student.ObjNum();
        }
    }
    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    class Student
    {
        string name;
        string mail;
        string major;
        string university;
        int phone;
        static int i;
        public Student(string n, string m, string j, string u, int p)
        {
            name = n;
            mail = m;
            major = j;
            university = u;
            phone = p;
            int nu = i++;
        }
        public Student(string n)
        {
            this.name = n;
            this.mail = "No Mail";
            this.university = "MU";
            this.phone = 0;
            this.major = "CS";
            int nu = i++;
        }
        public static void ObjNum()
        {
            int n = i;
            Console.WriteLine("Number of Students = " + n);
        }
        public void print()
        {
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Mail : " + mail);
            Console.WriteLine("Student University : " + university);
            Console.WriteLine("Student Major : " + major);
            Console.WriteLine("Student Phone : " + phone);
            Console.WriteLine("**************************");
        }
    }
}