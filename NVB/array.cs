using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class array
    {
        public static void Main(string[] args)
        {
            //Initialization of an array
            int[] b = {10, 20, 30, 40, 50};

            int[] a = new int[5];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;

            int[] c = new int[5];
            Console.WriteLine("Enter elements of array");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            //printing array

            for(int i = 0; i < c.Length; i++){
                Console.Write(c[i] + " ");
            }

            Console.WriteLine();

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //avg

            double sum = 0;
            foreach(int i in c)
            {
                sum += i;
            }
            Console.WriteLine("Avg of goven input array :" + (sum/c.Length));



        }
    }
}
