using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_03
{
    class Student
    {
        private string ennum;
        private string name;

        public string EnNum
        {
            get
            {
                return ennum;
            }
            set
            {
                ennum = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }


    internal class Q07
    {
        public static void Main()
        {
            Student obj = new Student();
            obj.EnNum = "23SOECE11035";
            obj.Name = "Mahesh";

            Console.WriteLine("Name : " + obj.Name);
            Console.WriteLine("Enrollment Number : " + obj.EnNum);
        }
    }
}
