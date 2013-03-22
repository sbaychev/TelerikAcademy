using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryDigitCount
{
    class BinaryDigitCount
    {
//You are given a sequence of N positive integer numbers and one binary digit B (0 or 1). 
//Your task is to write a program that finds the number of binary digits (B) in each of the N numbers in binary numeral 
//system. Example: 20 in the binary numeral system looks like this: 10100. The number of binary digits 0 of the number 20 
//in the binary numeral system is 3.
//Input
//The input data is being read from the console. 
//On the first input line there will be the digit B.
//On the second line you must read the number N.
//On each of the following N lines there is one positive integer number written – the consequent number, whose sum of binary
//digits B we are searching for.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output must be printed on the console.
//In the output you must have N lines. Each line must have 1 integer number – the number of digits B in the binary 
//representation of the given consequent number.
//Constraints
//•	Number N is a positive integer between 1 and 1000, inclusive.
//•	Each of the N numbers is a positive integer between 1 and 4 000 000 000, inclusive.
//•	The digit B will be only 0 or 1.

        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            uint[] nNumbers = new uint[n];
            int[] timesOneOrZero = new int[n];
            for (int i = 0; i < n; i++)
            {
                nNumbers[i] = uint.Parse(Console.ReadLine());
            }
            if (b == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    for (timesOneOrZero[j] = 0; nNumbers[j] > 0; timesOneOrZero[j]++)
                    {
                        nNumbers[j] &= nNumbers[j] - 1; // clear the least significant bit set
                    }
                }
            }
            else
            {
                uint[] nRevNumbers = new uint[n];
                for (int t = 0; t < n; t++)
                {
                    nRevNumbers[t] = nNumbers[t];
                }                
                for (int j = 0; j < n; j++)
                {
                    for (timesOneOrZero[j] = 0; nRevNumbers[j] > 0; )
                    {                       
                        if (((nRevNumbers[j] & (1U << 0)) == 0) && nRevNumbers[j] > 0)
                        {
                            timesOneOrZero[j]++;
                        }
                        nRevNumbers[j] >>= 1;
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(timesOneOrZero[k]);
            }
        }
    }
}