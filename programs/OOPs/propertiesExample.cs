using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    class StudetPoperty
    {
        private string firstname; 
        private string lastname;

        // getter and setter (java)
        public string GetFirstName()
        {
            return firstname;
        }
        public void setLastName(string value)
        {
            this.firstname = value;
        }

        // Using property
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }


    }

    
    internal class propertiesExample
    {
        public static void Main()
        {
            StudetPoperty s1 = new StudetPoperty();
            StudetPoperty s2 = new StudetPoperty();

            // Method - 1 (java)
            s1.setLastName("Ramesh");
            Console.WriteLine(s1.GetFirstName());

            // Method - 2 (properties)
            s2.FirstName = "Ramesh";
            Console.WriteLine(s2.FirstName);
        }
    }
}
