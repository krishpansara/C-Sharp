using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    public class staticEx
    {
        public int x;
        static int y = 2;

        public staticEx(int x)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine("X is : " + x);
            Console.WriteLine("y is : " + y);
            Console.WriteLine("y is : " + staticEx.y);
        }

        public int addNum()
        {
            //staticEx ob = new staticEx();
            return x + y;
        }
    }

    public static class staticClass
    {
        static int x = 10;

        static staticClass()
        {
            Console.WriteLine("Static Constructor is Called");
        }

        public static void show()
        {
            Console.WriteLine("X is : " + x);
        }
    }

    internal class staticExample
    {
        static void Main()
        {
            staticClass.show();

            staticEx obj1 = new staticEx(30);
            Console.WriteLine("Addition id : " + obj1.addNum());
            obj1.show();        
        }
    }
}
