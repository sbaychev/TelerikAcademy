using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOnePlusOneAndEtcOverOne
{
    class SumOnePlusOneAndEtcOverOne
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
            //In mathematics, the n-th harmonic number is the sum of the reciprocals of the first n natural numbers
            //alternating harmonic numbers
            decimal accuracy = 0.001m;
            decimal curSum = 1 + (decimal)1/2;
            decimal firSum = 0.0m;
            for (int i = 1; Math.Abs(curSum - firSum) > accuracy; i++)
            {
                firSum = curSum;
                decimal nHar = (decimal)(1 / ((i + 2) * (Math.Pow((-1), i))));
                curSum += nHar;
            }
            Console.WriteLine("The sum with accuracy of 0.001 is: {0:F3}\n", curSum);
        }
    }
}