using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class Product
    {
        int pCode;
        string pName;
        string mName;
        public Product() { }     //default constructor 
        public Product(int pCode, string pName, string mName)
        {
            this.pCode = pCode;
            this.pName = pName;
            this.mName = mName;
        }

        public void display()
        {
            Console.WriteLine("pCode : " + pCode);
            Console.WriteLine("pName : " + pName);
            Console.WriteLine("mName : " + mName);

        }
    }
    internal class Q4
    {
        public static void Main(String[] args)
        {
            int pCode;
            string pName;
            string mName;
            if (args.Length > 0)
            {
                pCode = Int32.Parse(args[0]);
                pName = args[1];
                mName = args[2];
            }
            else
            {
                pCode = 1;
                pName = "Laptop";
                mName = "XYZ";
            }
                Product p1 = new Product(pCode, pName, mName);

            p1.display();
        }
    }
}
