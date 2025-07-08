using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class array_max
    {
        public static void Main(String[] args)
        {

            int[] c = new int[5];
            Console.WriteLine("Enter elements of array");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
                if (c[i] < min)
                {
                    min = c[i];
                }
            }

            Console.WriteLine($"Max Element : {max}");


        }
    }
}