using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q06
    {
        public static void Main(string[] args)

        {
            int[] arr = { 12, 45, 67, 2, 89, 5 };
            int max = arr[0], min = arr[0];

            foreach (int item in arr)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }

            Console.WriteLine($"Maximum = {max}");
            Console.WriteLine($"Minimum = {min}");

        }
    }
}
