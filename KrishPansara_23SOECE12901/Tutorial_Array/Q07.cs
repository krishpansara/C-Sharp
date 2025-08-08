using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q07
    {
        public static void Main(string[] args)

        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] even = { };
            int[] odd = { };

            foreach (int item in arr)
            {
                if (item % 2 == 0)
                    even = even.Append(item).ToArray();
                else
                    odd = odd.Append(item).ToArray();

            }

            Console.WriteLine("Even numbers:");
            foreach (int e in even) Console.WriteLine(e);

            Console.WriteLine("Odd numbers:");
            foreach (int o in odd) Console.WriteLine(o);
        }
    }
}
