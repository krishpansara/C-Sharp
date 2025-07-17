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
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            string[] ans = {};

            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            while (number > 0)
            {
                temp = number % 10;
                ans = ans.Append(words[temp]).ToArray();
                number = number / 10;
            }

            for(int i = ans.Length - 1; i >= 0; --i)
            {
                Console.Write(ans[i] + " ");
            }

            //Console.Read();
        }
    }
}
