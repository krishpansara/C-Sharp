using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            string result = "";

            foreach(char c in name)
            { 
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }

            Console.WriteLine(result);
        }
    }
}
