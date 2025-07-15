//initalize a1 by using user input
//initalize a2 by using user input

//do sum of a1 and a2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.array
{
    internal class addition_2d_matrics
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter input for matrics 1 : ");
            int[,] a1 = new int[3, 2];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("Enter input for matrics 2 : ");
            int[,] a2 = new int[3, 2];
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    a2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.Write(a1[i, j] + " + " + a2[i, j] + "       ");
                }

                Console.WriteLine();
            }



            Console.WriteLine("Enter input for matrics 1 : ");
            int[,] sum = new int[3, 2];
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = a1[i, j] + a2[i, j];
                    Console.Write(sum[i, j]+  " " );

                }

                Console.WriteLine();
            }
        }
    }
}
