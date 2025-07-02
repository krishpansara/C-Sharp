using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Loops
    {
        public static void Main(string[] args)
        {
            int no = 0;

            while (no < 10)
            {
                Console.WriteLine(++no);
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine(i);
            }

        }
    }
}
