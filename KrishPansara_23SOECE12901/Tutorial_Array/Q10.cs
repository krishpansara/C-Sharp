using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_Array
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            int[,] mat1 = { { 1, 2 }, { 3, 4 } };
            int[,] mat2 = { { 5, 6 }, { 7, 8 } };
            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
