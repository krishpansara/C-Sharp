﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int n, fact = 1;

            Console.WriteLine("Enter Number : ");

            string str = Console.ReadLine();
            n = Convert.ToInt32(str);

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial : {0}", fact);

            Console.Read();

        }
    }
}
