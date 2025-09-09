using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs.inheritance
{
    class A
    {
        int x;
        public int X
        {
            get { return x; }
        }
        public A(int x)
        {
            Console.WriteLine("Constructor from Base-A");
            this.x = x;
        }
        public void methodA1()
        {
            Console.WriteLine("Method-1 From Base A");
        }
        protected void methodA2()
        {
            Console.WriteLine("Method-2 from Base A");
        }
    }

    class B : A
    {
        int y;
        public int Y
        {
            get { return y; }
        }
        public B(int x, int y) : base(x)
        {
            this.y = y;
            Console.WriteLine("Constructor from Child B");
        }
        public void methodB1()
        {
            methodA2();
            Console.WriteLine("Method-1 From Derived B");
        }

        public void calcAvg()
        {
            double avg = (double)(X + Y) / 2;
            Console.WriteLine(avg);
        }
    }

    internal class inherit_demo
    {
        public static void Main()
        {
            B obj = new B(5, 10);
            obj.methodA1();
            obj.methodB1();
            obj.calcAvg();

            double avg = (obj.X + obj.Y) / 2;
            Console.WriteLine(avg);

        }
    }
}
