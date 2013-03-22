using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NfactCalc
{
    class NfactCalc
    {
        static void Main(string[] args)
        {
            //Write a program to calculate n! for each n in the range [1..100]. 
            //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} = {1}", i, factorial(i));
            }
        }
        public static BigInteger factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        }
    }
}
