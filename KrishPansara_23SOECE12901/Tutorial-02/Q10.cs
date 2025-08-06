using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q10
    {
        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            int row = 0;
            int col = M - 1;

            while (row < N && col >= 0)
            {
                if (mat[row, col] == X)
                    return 1;
                else if (mat[row, col] > X)
                    col--;
                else
                    row++;
            }

            return 0;
        }

        static void Main()
        {
            // Example 1
            int[,] mat1 = {
                { 3, 30, 38 },
                { 44, 52, 54 },
                { 57, 60, 69 }
            };
            int N1 = 3, M1 = 3, X1 = 62;
            Console.WriteLine("Output Example 1: " + matSearch(mat1, N1, M1, X1));

            // Example 2
            int[,] mat2 = {
                { 18, 21, 27, 38, 55, 67 }
            };
            int N2 = 1, M2 = 6, X2 = 55;
            Console.WriteLine("Output Example 2: " + matSearch(mat2, N2, M2, X2));

        }
    }
}
