using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{


    internal class classDemo3
    {
        public static void Main()
        {
            Student[] s = new Student[2];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
            }
        }
    }
}
