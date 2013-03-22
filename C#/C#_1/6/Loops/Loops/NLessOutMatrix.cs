using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLessOutMatrix
{
    class NLessOutMatrix
    {
        static void Main(string[] args)
        {
        //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
            Console.Write("Please enter a number less than 20: ");
            int varNum = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAnd you are going to get a matrix that is going to have a size of {0}\n", varNum);
            for (int row = 1; row <= varNum; row++)
            {
                for (int column = 0; column < varNum; column++)
                {
                    Console.Write("{0} ", row + column);
                }
                Console.WriteLine();
            }
        }
    }
}