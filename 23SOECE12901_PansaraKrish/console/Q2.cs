using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Q2
    {
        public static void Main()
        {
            int k = 1;
            for(int i = 0; i < 4; i++){
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
