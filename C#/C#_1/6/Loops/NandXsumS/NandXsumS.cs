using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NandXsumS
{
    class NandXsumS
    {
        static void Main(string[] args)
        {
            //Write a program that for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N
            Console.Write("N = ");
            int varN = int.Parse(Console.ReadLine());
            int factN = 1; //where the factorial of N is stored
            Console.Write("X = ");
            int varX = int.Parse(Console.ReadLine());
            double sumS = 1;
            for (int i = 1; i <= varN; i++)
            {
                factN = factN * i;
                sumS += (double)(factN) / (int)(Math.Pow(varX, i));
            }
            Console.WriteLine();
            Console.WriteLine(sumS);
            Console.WriteLine();
        }
    }
}