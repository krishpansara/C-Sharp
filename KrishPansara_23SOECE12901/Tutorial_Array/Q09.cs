using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q09
    {
        public static void Main(string[] args)

        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.Write("Enter position to delete (0-based index): ");
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 0 || pos >= arr.Length)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            Console.WriteLine("Array after deletion:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos) continue;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
