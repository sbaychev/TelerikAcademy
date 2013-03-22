using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivSevAndThreeOneToN
{
    class DivSevAndThreeOneToN
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
            Console.Write("N = ");
            int varN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= varN; i++) //including N
            {
                if (!((i % 3 == 0) && (i % 7 == 0)))
                {
                    Console.Write("{0} ", i);   
                }
            }
            Console.WriteLine();
        }
    }
}