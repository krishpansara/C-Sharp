using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q04
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter first number (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            // arithmetic Operators
            Console.WriteLine("\narithmetic Operations:");
            Console.WriteLine("addition (a + b): " + (a + b));
            Console.WriteLine("Subtraction (a - b): " + (a - b));
            Console.WriteLine("Multiplication (a * b): " + (a * b));
            Console.WriteLine("Division (a / b): " + ((float)a / b));
            Console.WriteLine("Modulus (a % b): " + (a % b));

            // Relational Operators
            Console.WriteLine("\nRelational Operations:");
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));

            // Logical Operators
            Console.WriteLine("\nLogical Operations:");
            bool cond1 = a > 0;
            bool cond2 = b > 0;
            Console.WriteLine("a > 0 && b > 0: " + (cond1 && cond2));
            Console.WriteLine("a > 0 || b > 0: " + (cond1 || cond2));
            Console.WriteLine("!(a > 0): " + (!cond1));

            // Bitwise Operators
            Console.WriteLine("\nBitwise Operations:");
            Console.WriteLine("a & b: " + (a & b));
            Console.WriteLine("a | b: " + (a | b));
            Console.WriteLine("a ^ b: " + (a ^ b));
            Console.WriteLine("~a: " + (~a));
            Console.WriteLine("a << 1: " + (a << 1));
            Console.WriteLine("b >> 1: " + (b >> 1));

            // assignment Operators
            Console.WriteLine("\nassignment Operations:");
            int C = a;
            C += b;
            Console.WriteLine("C += b: " + C);
            C -= b;
            Console.WriteLine("C -= b: " + C);
            C *= b;
            Console.WriteLine("C *= b: " + C);
            C /= b;
            Console.WriteLine("C /= b: " + C);

            // Data types demonstration
            Console.WriteLine("\nData Types:");
            float floatResult = (float)a / b;
            double doubleResult = Math.Sqrt(a * a + b * b);
            char exampleChar = 'Z';
            bool exampleBool = a != b;
            string exampleString = $"The numbers are a = {a}, b = {b}";

            Console.WriteLine("Float result (a / b): " + floatResult);
            Console.WriteLine("Double result (√(a² + b²)): " + doubleResult);
            Console.WriteLine("Char example: " + exampleChar);
            Console.WriteLine("Boolean example (a != b): " + exampleBool);
            Console.WriteLine("String example: " + exampleString);

            Console.ReadLine();
        }
    }
}
