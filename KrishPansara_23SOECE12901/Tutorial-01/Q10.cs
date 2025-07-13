using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_01
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Mobile Number:");
            string no = Console.ReadLine();
            string res = "";

            for(int i = 0; i < no.Length; i++)
            {
                if (i < 5)
                {
                    res += no[i];
                }
                else
                { 
                    res += "X";
                }
            }
            Console.WriteLine(res);

        }
    }
}
