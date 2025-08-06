using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q12
    {
        static void Main()
        {
            Console.Write("Enter number of elements in array: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

            Console.ReadLine();
        }
    }
}
