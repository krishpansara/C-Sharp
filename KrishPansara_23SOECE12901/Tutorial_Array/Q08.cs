using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q08
    {
        public static void Main(string[] args)

        {
            int[] arr = { 5, 3, 8, 1, 2 };
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("Sorted array (descending):");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
