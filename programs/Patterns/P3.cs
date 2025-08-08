using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*****
//****
//***
//**
//*

namespace programs.Patterns
{
    internal class P3
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 + 1 - i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

        }
    }
}
