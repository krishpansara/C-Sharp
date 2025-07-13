using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q18
    {
        public static void Main(string[] args)
        {
            int ctr = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write(++ctr + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
