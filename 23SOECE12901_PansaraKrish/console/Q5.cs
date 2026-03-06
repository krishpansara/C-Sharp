using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class Student
    {
        int roll_no, sem;
        double phy, chem, math, avg;
        string name;

        public Student(int roll_no, string name, int sem, double phy, double chem, double math)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.phy = phy;
            this.sem = sem;
            this.chem = chem;
            this.math = math;
        }

        public void calc_avg()
        {
            avg = (phy + chem + math) / 3.0;
        }

        public void show()
        {
            Console.WriteLine("Roll No : " + roll_no);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Semester : " + sem);
            Console.WriteLine("Physics Mark : " + phy);
            Console.WriteLine("Chemistry Mark : " + chem);
            Console.WriteLine("Maths Mark : " + math);
            Console.WriteLine("Average Mark : " + avg);
            Console.WriteLine();
        }
    }
    internal class Q5
    {
        public static void Main()
        {
            Student s1 = new Student(1, "Rushi", 5, 45, 43, 26);
            Student s2 = new Student(2, "Deep", 5, 25, 23, 36);
            Student s3 = new Student(3, "Het", 5, 49, 33, 46);

            s1.calc_avg();
            s2.calc_avg();
            s3.calc_avg();

            s1.show();
            s2.show();
            s3.show();
        }
    }
}
