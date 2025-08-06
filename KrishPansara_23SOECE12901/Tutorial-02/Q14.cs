using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q14
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int total = maths + physics + chemistry;
            int mathPhysicsTotal = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (total >= 180 || mathPhysicsTotal >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

        }
    }
}
