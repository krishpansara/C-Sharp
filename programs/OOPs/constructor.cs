using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    - initialize private mamber within class
    - special method as class
        -- same name as class name
    - never return any value (not even void)
    - automatically called when obj of the class is created
 
    => types : 
        => user defined 
            -- default : no args taken, assign defalut values
            -- parameterised : args in constructers, same num of args to pass while creating an obj
        
        => provided by compiler (bu default) : when we dont create any constructure
            -- copy : when we have to craete new obj from existing obj (same setes of vals)
            -- static : not take any args, called only once, intitialize static member of the class
            -- private : private, paarameter less, not contain any args, acessed within class, when all the members of class are static

*/


namespace programs.OOPs
{
    class EmployeeDemo
    {
        int empID;
        string name;
        string city;

        public EmployeeDemo()
        {

        }

        public EmployeeDemo(int empID, String name)
        {
            this.empID = empID;
            this.name = name;
        }

        public EmployeeDemo(int empID, string name, string city) : this(empID, name)
        {
            this.city = city;
        }

        public void Display()
        {
            Console.WriteLine("Employee ID : " + empID);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee City : " + city);
        }
    }

    class constructor
    {
        public static void Main()
        {
            EmployeeDemo emp1 = new EmployeeDemo();
            EmployeeDemo emp2 = new EmployeeDemo(1, "Dhrups", "Rajkot");
            emp2.Display();
        }
    }
}
