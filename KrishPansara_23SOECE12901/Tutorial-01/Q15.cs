using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp = num;

            while (temp > 0)
            {
                int digit = temp % 110;
                sum = (int)Math.Pow(digit, 3) + sum;
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine($"Armstrong number.");
            }
            else
            {
                Console.WriteLine("Not an Armstrong number.");
            }
        }

    }
}
