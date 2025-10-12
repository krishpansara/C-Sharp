using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.programs.method_overriding
{
    class Employee
    {
        public int Id { get; set; }
        public String name{ get; set; }
        public String designation { get; set; }
        public double salary { get; set; }

        public virtual double CalculateBonus(double Salary)
        {
            return 20000.00;
        }
    }

    class Developer : Employee
    {
        public override double CalculateBonus(double Salary)
        {
            double baseSalary = base.CalculateBonus(Salary);
            double calSalary = Salary * 0.2;

            if (baseSalary > calSalary)
                return baseSalary;
            else
                return calSalary;
        }
    }

    class Tester : Employee
    {
        public override double CalculateBonus(double Salary)
        {
           return 30000.00;
        }
    }

    class Admin : Employee
    {
        public override double CalculateBonus(double Salary)
        {
            return 10000.00;
        }
    }


    internal class demoOverriding
    {
        public static void Main()
        {
            Employee emp1 = new Developer
            {
                Id = 101,
                name = "Rushi",
                designation = "Software Developer",
                salary = 80000,
            };

            double bonus = emp1.CalculateBonus(emp1.salary);
            Console.WriteLine($"Employee 1 Details: {emp1.Id}, {emp1.name}, {emp1.designation},{emp1.salary}, {bonus}");

            Employee emp2 = new Tester
            {
                Id = 102,
                name = "Aditya",
                designation = "Auto Tester",
                salary = 20000,
            };


            bonus = emp2.CalculateBonus(emp2.salary);
            Console.WriteLine($"Employee 2 Details: {emp2.Id}, {emp2.name}, {emp2.designation},{emp2.salary}, {bonus}");


        }
    }
}
