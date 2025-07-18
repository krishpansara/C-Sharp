using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.array
{
    internal class array_methods
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 15, 26, 95, 10, -52, 56 };
            Console.WriteLine("Array Min: " + a.Min());
            Console.WriteLine("Array Max: " + a.Max());
            
            var rev = a.Reverse();
            Console.WriteLine("\nReverse is : ");
            
            foreach (var item in rev)
            {
                Console.Write(item + " ");
            }

            Array.Sort(a);
            Console.WriteLine("\nSorted Array : ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }


        }
    }
}
