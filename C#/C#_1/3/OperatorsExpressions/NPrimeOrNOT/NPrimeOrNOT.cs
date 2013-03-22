using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPrimeOrNOT
{
    class NPrimeOrNOT
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime
            Console.Write("Enter an integer number n, where -> 100 ≥ n > 0: ");
            uint primeOrNot = uint.Parse(Console.ReadLine());
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(primeOrNot);
            //If both a and b were greater than the square root of n, a*b would be greater than n.
            //So at least one of those factors must be less or equal to the square root of n, and to check if n is prime, we only need to 
            //test for factors less than or equal to the square root.
            Console.WriteLine(maxDivider);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                Console.WriteLine(divider);
                if (primeOrNot % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            if (!prime)
            {
                Console.WriteLine("\n\nThe number {0} that you have Entered, is Not Prime", primeOrNot);
            }
            else
            {
                Console.WriteLine("\n\nThe number {0} that you have Entered, is Prime.", primeOrNot);
            }
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}