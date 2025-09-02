using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    public class Student1
    {
        int r_no, sub1, sub2, sub3;
        string name, branch;
        static int sem = 5;
        double avg;

        public Student1(int r_no, string name, string branch, int sub1, int sub2, int sub3)
        {
            this.r_no = r_no;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.name = name;
            this.branch = branch;
        }

        public double Avg
        {
            get { return avg; }
        }

        public void calculate_avg()
        {
            avg = (sub1 + sub2 + sub3) / 3.0; 
        } 

        public void change_sem(int x)
        {
            sem = x;
        }

        public void ShowData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll no : " + r_no);
            Console.WriteLine("Branch : " + branch);
            Console.WriteLine("Semester : " + sem);
            Console.WriteLine("Average : " + avg);
        }

    }
    internal class problem2
    {
        public static void Main()
        {
            Student1 s1 = new Student1(1, "Rushi", "IT", 56, 8, 23);
            s1.ShowData();
            s1.calculate_avg();
            s1.change_sem(8);
            s1.ShowData();       
        }
    }
}
