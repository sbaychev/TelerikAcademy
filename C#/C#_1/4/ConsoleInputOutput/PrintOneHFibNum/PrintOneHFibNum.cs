using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintOneHFibNum
{
    class PrintOneHFibNum
    {
        static void Main(string[] args)
        {
            //Write a program to print the first 100 members of the sequence of Fibonacci: 
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            decimal firstF = 0;
            decimal secF = 1;
            Console.Write("1. {0}\n", firstF);
            for (int i = 2; i <= 100; i++)
            {
                decimal fibN = secF + firstF;
                firstF = secF;
                secF = fibN;
                Console.Write("{0}. {1}\n",i, secF);
            }
            Console.WriteLine();
        }
    }
}