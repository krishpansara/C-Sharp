using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q05
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1 };
            int duplicateCount = 0;
            bool[] visited = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i]) continue;
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                if (count > 1)
                {
                    duplicateCount++;
                    Console.WriteLine($"Duplicate: {arr[i]} (appears {count} times)");
                }
            }

            Console.WriteLine($"Total duplicate elements: {duplicateCount}");

        }
    }
