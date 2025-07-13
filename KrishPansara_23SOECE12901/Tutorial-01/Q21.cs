using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q21
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int digit = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                term = term * 10 + digit;
                sum += term;
                Console.Write(term + " + ");
            }
            Console.WriteLine();
            Console.Write(sum);
        }
    }
}
