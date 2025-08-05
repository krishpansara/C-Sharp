using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    class Student
    {
        int rollNo;
        string name;

        /*
        public Student()
        {
            rollNo = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
        }
        */

        // Default constructor
        public Student()
        {
            Console.WriteLine("Roll No: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
        }


        // Parameterized constructor
        public Student(int rollNo, string name)
        {
           this.rollNo = rollNo;
            this.name = name;
        }

        public void showData()
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
        }
    }

    internal class classDemo2
    {
        public static void Main()
        {
            Student s1 = new Student(100, "AAA");
            s1.showData();

            int x = 101;
            string y = "BBB";
            Student s2 = new Student(x, y);
            s2.showData();


            Student s3 = new Student();
            s3.showData();

        }
    }
}
