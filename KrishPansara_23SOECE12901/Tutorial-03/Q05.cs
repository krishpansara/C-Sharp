using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishPansara_23SOECE12901.Tutorial_03
{
    class Product
    {
        int pcode;
        String pname, mname;

        public Product(int pcd, String pnm, String mnm)
        {
            mname = mnm;
            pname = pnm;
            pcode = pcd;
        }

        public void Display()
        {
            Console.WriteLine("\nManufacturer Name:= " + mname);
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("\nProduct Name:= " + pname);
        }

    }

    internal class Q05
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                String pnm = args[1];
                String mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);

                p.Display();

                Console.Read();
            }
        }
    }
}

