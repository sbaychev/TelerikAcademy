using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NnumbersGreatSmall
{
    class NnumbersGreatSmall
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns the minimal 
            //and maximal of them
            Console.Write("N = ");
            int varN = int.Parse(Console.ReadLine());
            int[] varNums = new int [varN];
            Console.WriteLine();
            for (int i = 0; i < varNums.Length; i++)
            {
                varNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            //int greatest = varNums.Max();
            //int smallest = varNums.Min();
            int greatest = varNums[0];
            int smallest = varNums[0];
            for (int i = 0; i < varNums.Length; i++)
            {
                if (greatest < varNums[i])
                {
                    greatest = varNums[i];
                }
            }
            
            for (int i = 0; i < varNums.Length; i++)
            {
                if (smallest > varNums[i])
                {
                    smallest = varNums[i];
                }
            }
            Console.WriteLine();
            Console.Write("\nThe greatest number of N is: {0}\n", greatest);
            Console.Write("\nThe smallest number of N is: {0}\n", smallest);
            Console.WriteLine();
        }
    }
}