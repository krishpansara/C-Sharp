using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Q3
    {
        public static void Main()
        {
            int[] arr = { 5, 8, 6, 10, 2, 25 };
            int key = 2;
            bool avail = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == key)
                {
                    avail = true;
                }
            }

            if (avail)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");

            }
        }
    }
}
