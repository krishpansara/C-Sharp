using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_02
{
    internal class Q03
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Please enter a new first name:");

            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();

        }
    }
}
