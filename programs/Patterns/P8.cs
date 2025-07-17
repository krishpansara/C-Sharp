using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.Patterns
{
    internal class P8
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
   
            for (int i = 0; i < n+1; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == 0 || i == n || j == 0 || j == 2)
                    {
                        Console.Write(n + " ");
                    }
                    else
                    {
                        Console.Write((i) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
