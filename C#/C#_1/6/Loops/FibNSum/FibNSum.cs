using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibNSum
{
    class FibNSum
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates the sum of the first N members of the sequence of 
            //Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

            int current;  /* The value of the (i)th fibonacci number */
            int next;     /* The value of the (i+1)th fibonacci number */
            int twoAway;  /* The value of the (i+2)th fibonacci number */
            next = current = 1;
            Console.Write("N = ");
            int varN = int.Parse(Console.ReadLine());/* The number of fibonacci numbers */
            int sumFibN = 0;

            for (int i = 1; i < varN; i++)
            {
                sumFibN += current;
                twoAway = current + next;
                current = next;
                next = twoAway;
            }
            Console.WriteLine("\nThe sum of the first {0} members of the sequence of Fibonacci\n[0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...]\nis:\n\n{1}\n", varN, sumFibN);
        }
    }
}