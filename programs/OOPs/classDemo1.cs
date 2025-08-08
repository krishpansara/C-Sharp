using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    public class Employee
    {
        int empID;
        string empName;
        double salary;

        public void getData(int empID, string empName, double salary)
        {
            this.empID = empID;
            this.empName = empName;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Emp ID : " + empID);
            Console.WriteLine("Emp Name : " + empName);
            Console.WriteLine("Salary : " + salary);
        }

        public double getSalary()
        {
            return salary;
        }
    }
    internal class classDemo1
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.getData(1, "Rushi", 10000);
            e1.showData();

            Employee e2 = new Employee();
            e2.getData(2, "Man", 100);
            e2.showData();

            if (e1.getSalary() > e2.getSalary())
            {
                e1.showData() ;
            }
            else
            {
                e2.showData();
            }
        }
    }
}
