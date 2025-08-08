using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_03
{
    class Line
    {
        private double length;

        public Line()
        {
            length = 10;
            Console.WriteLine("Object is being created, length = {0}", length);
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }
    }

    internal class Q06
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            Console.WriteLine("Length of line : {0}", line.getLength());
            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}

