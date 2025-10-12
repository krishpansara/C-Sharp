using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.programs.method_overriding
{
    class P
    {
        public virtual void show()
        {
            Console.WriteLine("Show method from super class : P");
        }
    }

    class Q : P
    {
        public override void show()
        {
            Console.WriteLine("Show method from sub class : Q");
        }
    }
    internal class method_overriding
    {
        public static void main(String[] args)
        {
            P objp;
            Q objq = new Q();
            objp = objq;

            objp.show();
            objq.show();
        }
    }
}
