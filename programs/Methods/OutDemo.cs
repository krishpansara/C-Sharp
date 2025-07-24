using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Methods
{
    internal class OutDemo
    {
        static void Change(ref int a, ref int b)
        {
            a = 100;
            //b = 200
        }

        static void Update(out int a, out int b)
        {
            a = 100;
            //b = 200;
        }
        static void Main(string[] arg)
        {
            int a = 10, b = 20;
            int x = 10, y = 20;

            Console.WriteLine("Before change : a = {0}, b = {1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After change : a = {0}, b = {1}", a, b);

            Console.WriteLine("Before update : a = {0}, b = {1}", x, y);
            Update(out x, out y);
            Console.WriteLine("Before update : a = {0}, b = {1}", x, y);
        }
    }
}
