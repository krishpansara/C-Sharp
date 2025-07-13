using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q11
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            String name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            string gender = Console.ReadLine();

            
            if(gender == "M")
            {
                Console.WriteLine("Mr. " + name);
            }
            else
            {
                Console.WriteLine("Ms. " + name);   
            }
        }
    }
}
