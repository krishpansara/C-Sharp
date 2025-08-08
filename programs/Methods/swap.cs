using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.Methods
{
    /// <summary>
    /// This is class that include swap methods
    /// </summary>
    internal class swap
    {

        /// <summary>
        /// This method swap two variable using temp variable
        /// </summary>
        /// <param name="a">first paramater or value</param>
        /// <param name="b">second parameter or value</param>
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// This method swap two variable using mathematicle operations
        /// </summary>
        /// <param name="a">first paramater or value</param>
        /// <param name="b">second parameter or value</param>
        static void MathSwap(ref int a, ref int b)
        {
            b = b + a; // 25
            a = b - a; // 10
            b = b - a;
        }

        public static void Main(string[] args) 
        {
            swap s = new swap(); 

            int a = 15, b = 10;
            Console.WriteLine("Before Swapping : a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After Swapping (using temp) : a = {0}, b = {1}", a, b);
           
            a = 15;
            b = 10;
            MathSwap(ref a, ref b);
            Console.WriteLine("After Swapping (without temp) : a = {0}, b = {1}", a, b);
        }
    }
}
