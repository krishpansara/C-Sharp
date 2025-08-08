using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q02
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            Console.WriteLine("Sorted array (ascending):");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
