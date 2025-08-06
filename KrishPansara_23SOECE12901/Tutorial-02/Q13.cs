using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q13
    {
        static void Main()
        {
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMinimum number of notes required:");

            foreach (int note in notes)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
                    amount %= note;
                }
            }
        }
    }
}
