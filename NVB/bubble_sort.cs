using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class bubble_sort
    {
        public static void Main(string[] args)
        {
            int[] c = new int[5];
            Console.WriteLine("Enter elements of array");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < c.Length; i++)
            {
                for(int j = 1; i < c.Length - i; j++)
                {
                    if (c[j] < c[j-1])
                    {
                        int temp = c[j];
                        c[j] = c[j-1];
                        c[j-1] = temp;
                    }

                }
            }

            foreach (int i in c)
            {
                Console.Write(i + " ");
            }
        }
    }
}
