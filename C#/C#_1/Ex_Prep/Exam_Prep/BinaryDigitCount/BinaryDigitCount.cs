using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryDigitCount
{
    class BinaryDigitCount
    {
        static void Main(string[] args)
        {
            /*You are given a sequence of N positive integer numbers and one binary digit B (0 or 1). Your task is to write a program
             * that finds the number of binary digits (B) in each of the N numbers in binary numeral system. 
             * Example: 20 in the binary numeral system looks like this: 10100. The number of binary digits 0 of the number 20 in the
             * binary numeral system is 3.
            Input
            The input data is being read from the console. 
            On the first input line there will be the digit B.
            On the second line you must read the number N.
            On each of the following N lines there is one positive integer number written – the consequent number, whose sum of 
             * binary digits B we are searching for.
            The input data will always be valid and in the format described. There is no need to check it explicitly.
            Output
            The output must be printed on the console.
            In the output you must have N lines. Each line must have 1 integer number – the number of digits B in the binary 
             * representation of the given consequent number.
            Constraints
            •	Number N is a positive integer between 1 and 1000, inclusive.
            •	Each of the N numbers is a positive integer between 1 and 4 000 000 000, inclusive.
            •	The digit B will be only 0 or 1.*/
            string bNum = Console.ReadLine();
            byte bDigit = byte.Parse(bNum);
            string nCountNum = Console.ReadLine();
            ushort nCount = ushort.Parse(nCountNum);
            uint[] numsOfN = new uint[nCount];
            for (int i = 0; i < nCount; i++)
            {
                string nNumbers = Console.ReadLine();
                numsOfN[i] = uint.Parse(nNumbers);
            }
            for (int j = 0; j < nCount; j++)
            {
                string binary = Convert.ToString(numsOfN[j], 2);


            }

        }
    }
}
