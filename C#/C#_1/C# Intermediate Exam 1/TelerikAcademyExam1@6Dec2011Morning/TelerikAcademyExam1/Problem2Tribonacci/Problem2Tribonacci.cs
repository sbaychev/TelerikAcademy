using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Problem2Tribonacci
{
    class Problem2Tribonacci
    {
//The Tribonacci sequence is a sequence in which every next element is made by the sum of the previous three elements from 
//the sequence.
//Write a computer program that finds the Nth element of the Tribonacci sequence, if you are given the first three elements 
//of the sequence and the number N. Mathematically said: with given T1, T2 and T3 – you must find Tn.
//Input
//The input data should be read from the console.
//The values of the first three Tribonacci elements will be given on the first three input lines.
//The number N will be on the fourth line. This is the number of the consecutive element of the sequence that must be found 
//by your program.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//At the only output line you must print the Nth element of the given Tribonacci sequence.
//Constraints
//•	The values of the first three elements of the sequence will be integers between -2 000 000 000 and 2 000 000 000.
//•	The number N will be a positive integer between 1 and 15 000, inclusive.

        static void Main(string[] args)
        {

            BigInteger current = BigInteger.Parse(Console.ReadLine());
            BigInteger next = BigInteger.Parse(Console.ReadLine());
            BigInteger twoAway = BigInteger.Parse(Console.ReadLine());
            BigInteger threeAway = 0;

            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.WriteLine(current);
            }
            else if (N == 2)
            {
                Console.WriteLine(next);
            }
            else if (N == 3)
            {
                Console.WriteLine(twoAway);
            }
            else
            {
                for (int i = 4; i <= N; i++)
                {
                    threeAway = current + next + twoAway;
                    current = next;
                    next = twoAway;
                    twoAway = threeAway;
                }
                Console.WriteLine(threeAway);
            }
        }
    }
}