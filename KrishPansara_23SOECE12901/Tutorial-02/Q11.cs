using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q11
    {
        static void Main()
        {
            Console.Write("Enter number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of array elements = " + sum);
            Console.ReadLine();
        }
    }
}
