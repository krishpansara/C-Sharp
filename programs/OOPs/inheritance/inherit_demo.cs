using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs.inheritance
{
    class A
    {
        public void methodA1()
        {
            Console.WriteLine("Method-1 From Base A");
        }
        void methodA2()
        {
            Console.WriteLine("Method-2 from Base A")
            }
    }

    class B : A
    {
        public void methodB1()
        {
            Console.WriteLine("Method-1 From Derived B");
        }
    }

    internal class inherit_demo
    {
        public static void Main()
        {
            B obj = new B();
            obj.methodA1();
            obj.methodB1();
        }   
    }
}
