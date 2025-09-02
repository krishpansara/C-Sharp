using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    public class EmpProb
    {
        int empCode;
        double basicPay, hra, da, totalPay;
        String empName, designatin, instName;

        public EmpProb(int empCode, String empName, String designatin, String instName, double basicPay)
        {
            this.empCode = empCode;
            this.basicPay = basicPay;
            this.empName = empName;
            this.designatin = designatin;
            this.instName = instName;
        }

        public void calculateHRA()
        {
            hra = (basicPay * 10) / 100;
            da = (basicPay * 45) / 100;
            totalPay = hra + da + basicPay;
        }

        public void showDetails()
        {
            Console.WriteLine("Emp ID : " + empCode);
            Console.WriteLine("Emp Name : " + empName);
            Console.WriteLine("Designation : " + designatin);
            Console.WriteLine("Compony Name : " + instName);
            Console.WriteLine("HRA : " + hra);
            Console.WriteLine("DA : " + da);
            Console.WriteLine("total Pay : " + totalPay);
        }
    }

    internal class problem1
    {
        public static void Main()
        {
            EmpProb emp1 = new EmpProb(01, "Rushi", "SD", "NesoSoft", 15000);
            EmpProb emp2 = new EmpProb(02, "Deep", "SD", "RKit", 20000);

            emp1.showDetails();
            emp2.showDetails();
        }
    }
}
