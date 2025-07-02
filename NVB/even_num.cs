using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class even_num
    {
        public static void Main(string[] args)
        {
            int count = 0, i = 0;
            while(count < 50)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }


            //for(int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

        }
    }
}
