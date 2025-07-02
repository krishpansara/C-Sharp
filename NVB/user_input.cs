using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class user_input
    {
        public static void Main(string[] args)
        {

            string str;
            Console.Write("Enter your name : ");
            str = Console.ReadLine();
            Console.WriteLine("Name : " + str);

            int a, b;
            Console.WriteLine("Enter value a & b");
            a = Convert.ToInt32(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum : " + (a + b));

        }
    }
}
