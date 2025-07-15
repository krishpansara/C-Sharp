using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.array
{
    internal class pattern_jagged_array
    {
        public static void Main(string[] args)
        {
            int[][] jag_arr = new int[7][];
            jag_arr[0] = new int[1];
            jag_arr[1] = new int[2];
            jag_arr[2] = new int[3];
            jag_arr[3] = new int[4];
            jag_arr[4] = new int[3];
            jag_arr[5] = new int[2];
            jag_arr[6] = new int[1];

            int cnt = 1;
            Console.WriteLine("Enter jagged array elements : ");
            for (int i = 0; i < jag_arr.Length; i++)
            {
                for (int j = 0; j < jag_arr[i].Length; j++)
                {
                    jag_arr[i][j] = j+1;
                }
            }

            Console.WriteLine("Jugged array is");
            for (int i = 0; i < jag_arr.Length; i++)
            {
                for (int j = 0; j < jag_arr[i].Length; j++)
                {
                    Console.Write(jag_arr[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
