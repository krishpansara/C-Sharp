using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.Methods
{
    internal class calc_methods
    {
        static int Addition(int a, int b) 
        {
            return a + b;
        }

        static int Substraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
        public static void Main(String[] args)
        {
            int a = 20, b = 10;

            Console.WriteLine($"Addition {a} + {b} : " + Addition(a, b));
            Console.WriteLine($"Substraction {a} - {b} : " + Substraction(a, b));
            Console.WriteLine($"Multiplication {a} * {b} : " + Multiplication(a, b));
            Console.WriteLine($"Division {a} / {b}: " + Division(a, b));

        }
    }
}
