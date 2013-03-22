using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NthCatalan
{
    class NthCatalan
    {
        static void Main(string[] args)
        {
            //In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: 2N)! / (N + 1)! * N!
            //Write a program to calculate the Nth Catalan number by given N., N >= 0
            //1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440, 9694845, ...
            Console.Write("N = ");
            ulong varN = ulong.Parse(Console.ReadLine());
            ulong factN = 1; //where the factorial of N is stored
            ulong factNtwo = 1;
            ulong factNplus = 1;
            for (ulong i = 1; i <= varN; i++)
            {
                factN = factN * i;
            }
            for (ulong i = 1; i <= (2*varN); i++)
            {
                factNtwo = factNtwo * i;
            }
            for (ulong i = 1; i <= (1 + varN); i++)
            {
                factNplus = factNplus * i;
            }
            ulong catalanN = factNtwo / (factNplus * factN); // (2N)! / (N + 1)! * N!
            Console.WriteLine("\nThe {0}th/ rd Catalan Number is: {1}\n", varN, catalanN);
        }
    }
}