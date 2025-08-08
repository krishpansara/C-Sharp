using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    class EmpDemo
    {
        private int eID, eSalary;
        private string eName;

        public EmpDemo()
        {

        }
        public void showData()
        {
            Console.WriteLine("Employee ID : " + eID);
            Console.WriteLine("Employee Name : " + eName);
            Console.WriteLine("Employee Salary : " + eSalary);
        }
    }

    internal class classDemo4
    {
        public static void Main(string[] args)
        {
            EmpDemo demo = new EmpDemo();

            demo.showData();
        }
    }
}
