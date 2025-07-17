using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Patterns
{
    internal class P9
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if((i+j) % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
