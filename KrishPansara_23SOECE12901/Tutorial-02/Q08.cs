﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    class NumberManipulator1
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());

            int sum = x + y + z;  // ✅ Correct summation of integers
            return sum;
        }
    }

    internal class Q08
    {
        \ static void Main(string[] args)
        {
            NumberManipulator1 n = new NumberManipulator1();

            /* local variable definition */
            int a, b, c, sum;

            /* calling a function to get the values */
            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);

            Console.ReadLine();
        }
    }
}
