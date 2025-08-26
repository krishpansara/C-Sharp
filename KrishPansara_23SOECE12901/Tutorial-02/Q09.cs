using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    class Program
    {
        static void FindTwoOddNumbers(int[] arr)
        {
            int xor = 0;

            foreach (int num in arr)
            {
                xor ^= num;
            }

            int setBit = xor & ~(xor - 1);
            int x = 0, y = 0;

            foreach (int num in arr)
            {
                if ((num & setBit) > 0)
                    x ^= num;
                else
                    y ^= num;
            }

            if (x < y)
                Console.WriteLine($"{x} {y}");
            else
                Console.WriteLine($"{y} {x}");
        }

        internal class Q09
        {
            static void Main()
            {
                // Example 1
                int[] arr1 = { 1, 2, 3, 2, 1, 4 };
                Console.WriteLine("Example 1 Output:");
                FindTwoOddNumbers(arr1);

                // Example 2
                int[] arr2 = { 2, 1, 3, 2 };
                Console.WriteLine("Example 2 Output:");
                FindTwoOddNumbers(arr2);
            }
        } 

    }
}
