using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            foreach (char c in number)
            {
                if (char.IsDigit(c))
                    Console.Write(words[c - '0'] + " ");
            }

        }
    }
}
