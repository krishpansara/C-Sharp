﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q06
    {
        class Program
        {
            static void Main(string[] args)
            {
                int a, b, c, result;
                string str;

                Console.Write("Enter Number   1: ");
                str = Console.ReadLine();
                a = Convert.ToInt32(str);

                Console.Write("Enter Number  2 : ");
                str = Console.ReadLine();
                b = Convert.ToInt32(str);

                Console.Write("Enter Number   3 : ");
                str = Console.ReadLine();
                c = Convert.ToInt32(str);

                result = Sum(a, b, c);
                Console.Write($"Sum of {a}, {b} and {c} is : " + result);
                Console.Read();

            }

            static int Sum(int x, int y, int z)
            {
                int res;
                res = x + y + z;
                return res;
            }
        }
    }
}
