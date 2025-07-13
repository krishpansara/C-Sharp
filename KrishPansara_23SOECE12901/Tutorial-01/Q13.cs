using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q13
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");
            for (int i = 2; i < 11; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
