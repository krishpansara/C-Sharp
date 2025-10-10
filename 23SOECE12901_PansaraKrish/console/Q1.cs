using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class Demo
    {
        private int n1;
        static int n2 = 20;

        public Demo(int n1)
        {
            this.n1 = n1;
        }

        public int get()
        {
            return n1;
        }
        public void set(int n)
        {
            n1 = n;
        }
    }

    public class DemoImplemented : Demo
    {
        public DemoImplemented(int n1) : Demo(){
           
        }
     }
    internal class Q1
    {

       
    }
}
