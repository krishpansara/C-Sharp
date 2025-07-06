using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*
//**
//***
//****
//*****
//*****
//****
//***
//**
//*

namespace PJT.Patterns
{
    internal class P5
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int lim;
                if (i <= 10 / 2) {
                    lim = i;
                } else {
                    lim = (10 - i + 1);
                }

                for (int j = 1; j <= lim; j++)
                {
                    //Console.Write(j);
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

    }
}
