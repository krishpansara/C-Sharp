using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.programs.abstraction
{
    abstract class X
    {
        protected int n1, n2;
        public X(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void addition(int n1, int n2)
        {
            Console.WriteLine($"Addition of {n1} + {n2} is :  {n1 + n2}");
        }
        //public abstract void method1();
        //public abstract void method2();

        public abstract void multiplication(int n1, int n2);
    }

    class Y : X
    {
        public Y(int n1, int n2) : base(n1, n2)
        {
        }

        public override void multiplication(int n1, int n2)
        {
            Console.WriteLine($"Addition of {n1} + {n2} is :  {n1 * n2}");

        }

        //public override void method1()
        //{
        //    Console.WriteLine("Abstract Method-1 from class Y");
        //}

        //public override void method2()
        //{

        //}
    }

    //class Z : X
    //{
    //    public override void method1()
    //    {

    //    }
    //    public override void method2()
    //    {
    //        Console.WriteLine("Abstract Method-2 from class Z");

    //    }
    //}

    internal class abstractTutorial
    {
        public static void Main()
        {
            Y objX = new Y(10, 12);
            objX.multiplication();
        }
    }
}
