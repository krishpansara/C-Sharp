using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    public class StudentProperty
    {
        private string firstname;
        private string lastname;

        private int age;

        public int Age { get; set; }

        // getter and setter (java)
        public string GetFirstName()
        {
            return firstname;
        }
        public void setFirstName(string value)
        {
            this.firstname = value;
        }

        // Using property
        // if we remove set accessor from below it will become read-only properties
        // if we remove get accessor from below it will become write  -only properties

        public string LastName //this is read-only property
        {
            /*get
            {
                return lastname;
            }*/
            set
            {
                lastname = value;
            }
        }
    }

    internal class propertiesExample
    {
        public static void Main()
        {
            StudentProperty s1 = new StudentProperty();
            StudentProperty s2 = new StudentProperty();

            // Method - 1 (java)
            s1.setFirstName("Ramesh");
            s1.setLastName("Ramani");

            Console.WriteLine(s1.GetFirstName());
            Console.WriteLine(s1.GetLastName());

            // Method - 2 (properties)
            s2.FirstName = "Ramesh";
            s2.LastName = "Ramani";
            Console.WriteLine(s2.FirstName);
            //Console.WriteLine(s2.LastName);  // it is giving an error because we have set this is write-only property

        }
    }
}