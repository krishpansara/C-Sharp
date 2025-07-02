using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q3
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter an integer to check if it is even or odd : ");
            int x = Convert.ToInt32(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
