using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strings
    {
        public static void Main(string[] args)
        {
            String str1, str2, str3;
            Console.Write("Enter String 1 : ");
            str1 = Console.ReadLine();

            Console.Write("Enter String 2 : ");
            str2 = Console.ReadLine();
            int len = str1.Length;

            Console.WriteLine("Length of String 1 : " + len);

            str3 = str1.ToLower();
            Console.WriteLine("String 1 in Lower Case : " + str3);

            str3 = str2.ToLower().ToUpper();
            Console.WriteLine("String 2 in Upperr Case : " + str3);

            // Concatination of strings
            str3 = str1 + str2;
            str3 = str1 + " " + str2;

            Console.WriteLine("String 1 + String 2 : " + str3);

            // Using Concate
            str3 = String.Concat(str1, str2);
            Console.WriteLine("Combined Using Concate : " + str3);

            // interpolation of string 
            int no = 100;
            str3 = $"Multiplication of number with 10 {no * 10}";
            Console.WriteLine("String 3 is : " + str3);


        }
    }
}
