using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                BigInteger numdigits = (BigInteger)Math.Log10((double)K); // would return numdigits - 1
                BigInteger multiplier = (BigInteger)Math.Pow(10.0, (double)numdigits);
                //ulong q = K / 10;
                BigInteger r = K % 10;
                //1234 = 123;
                K = K / 10;
                K = K + multiplier * r;
            }
            Console.WriteLine(K);
        }
    }
}