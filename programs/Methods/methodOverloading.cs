using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.Methods
{
    class methodOverloading
    {
        static void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        static void Sum(int x, int y, int z)
        {
            Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
        }

        static void Sum(double x, double y)
        { 
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Main(string[] args)
        {
            Sum(5, 10);
            Sum(5, 10, 15);
            Sum(5.1, 10.59);

        }
    }
}