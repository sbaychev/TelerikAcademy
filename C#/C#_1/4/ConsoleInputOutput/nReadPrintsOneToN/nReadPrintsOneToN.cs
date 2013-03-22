using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nReadPrintsOneToN
{
    class nReadPrintsOneToN
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
            each on a single line.*/
            Console.Write("Please Enter an Integer Number: ");
            int varN = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe numbers in the interval [1...{0}] are: \n", varN);
            for (int i = 1; i <= varN; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
        }
    }
}