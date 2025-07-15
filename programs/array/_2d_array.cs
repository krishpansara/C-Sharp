using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  programs.array
{
    internal class _2d_array
    {
        public static void Main(string[] args)
        {
            int[,] a = new int[2, 2];  // 2x2
            a[0,0] = 1; a[0,1] = 2; 
            a[1,0] = 3; a[1,1] = 4;

            Console.WriteLine(a[0,0]);


            int[,] b = { { 1, 2 }, { 3, 4 } };  // 2x2
            Console.WriteLine(b[0, 0]);


            int[,] c = { { 1, 2 }, { 3, 4 }, { 5, 6 } };  // 3x2
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Enter input for matrics : ");
            int[,] d = new int[3, 2];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    d[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

        }
    }
}
