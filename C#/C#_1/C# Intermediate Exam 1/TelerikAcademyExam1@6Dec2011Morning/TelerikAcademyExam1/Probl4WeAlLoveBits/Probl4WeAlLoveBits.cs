using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Probl4WeAlLoveBits
{
    class Probl4WeAlLoveBits
    {

//One of the things the programmers love the most is bitwise operations. The "bitwise guy" is a synonym for a programmer 
//that loves bits more than everything else in programming. Mitko is a "bitwise guy". He invented a new bitwise algorithm. 
//The algorithm takes one positive integer P, makes magic with it and returns a new positive integer. He also defined a new 
//number P̃ which represents the number P in binary numeral system with inverted bits. All zeros in P are ones in P̃ and all
//ones in P are zeros in P̃. For example if we have P = 9 (which is 1001 in binary numeral system) its inverted number P̃ will
//be equal to 6 (which is 110 in binary numeral system). But that’s not all! He invented another number P̈, which represents 
//reversed number P in binary numeral system. For example if we have P = 11 (which is 1011 in binary numeral system) its 
//reversed number P̈ is equal to 13 (which is 1101 in binary numeral system). Mitko's magical algorithm takes a number P and 
//transforms it to a new number Pnew using the following bitwise transformation: Pnew = (P ^ P̃) & P̈.
//Your task is to write a program that transforms a sequence of N positive integer numbers using Mitko's algorithm.
//Input
//The input data should be read from the console.
//At the first input line there will be one positive integer – the number N.
//At each of the next N lines there will be one positive integer – the consequent number that must be converted using 
//Mitko's algorithm.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output must consist of N lines, containing the transformed numbers for each number from the input.
//Constraints
//•	The number N will be positive integer number between 1 and 800, inclusive.
//•	Each of the N numbers will be positive integer numbers between 1 and 2 147 483 647, inclusive.

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] nNumbers = new long[N];
            for (int i = 0; i < N; i++)
            {
                nNumbers[i] = long.Parse(Console.ReadLine());
            }
            long[] pTildeNnumbers = new long[N];
            long[] pUmlautNnumbers = new long[N];
            long[] tempPNewNnumbers = new long[N];
            long[] pNewNnumbers = new long[N];
            int[] timesZerOrOne = new int[N];
            for (int i = 0; i < N; i++)
            {
                pUmlautNnumbers[i] = pTildeNnumbers[i] = pNewNnumbers[i] = tempPNewNnumbers[i] = nNumbers[i];
            }
            //for (int i = 0; i < N; i++)
            //{
            //    for (timesZerOrOne[i] = 0; nNumbers[i] > 0;  nNumbers[i] >>= 1)
            //    {
            //        if (((nNumbers[i] & (1L << 0)) == 0) || ((nNumbers[i] & (1L << 0)) == 1))
            //        {
            //            timesZerOrOne[i]++;
            //        }
            //    }
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    while (timesZerOrOne[i] % 4 != 0)
            //    {
            //        timesZerOrOne[i]++;
            //    }
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    pTildeNnumbers[i] = pTildeNnumbers[i] ^ (~(0L << timesZerOrOne[i]));
            //}
            for (int i = 0; i < N; i++)
            {
                string complementedBinaryNumber = Convert.ToString(~pTildeNnumbers[i], 2);
                pTildeNnumbers[i] = Convert.ToInt64(complementedBinaryNumber, 2);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(pTildeNnumbers[i]);
            }
            for (int i = 0; i < N; i++)
            {
                long pUmlaut = 0;
                while (pUmlautNnumbers[i] != 0)
                {
                    pUmlaut <<= 1;
                    pUmlaut |= (pUmlautNnumbers[i] & 1);
                    pUmlautNnumbers[i] >>= 1;
                }
                pUmlautNnumbers[i] = pUmlaut;
            }
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(tempPNewNnumbers[i] ^ pTildeNnumbers[i]);
            //    Console.WriteLine(pUmlautNnumbers[i]);
            //    Console.WriteLine((tempPNewNnumbers[i] ^ pTildeNnumbers[i]) & pUmlautNnumbers[i]);
            //}
            //Pnew = (P ^ P̃) & P̈
            for (int i = 0; i < N; i++)
            {
                pNewNnumbers[i] = (tempPNewNnumbers[i] ^ pTildeNnumbers[i]) & pUmlautNnumbers[i];
            }
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(pNewNnumbers[i]);
            //}
        }
    }
}