using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetMax
{
    class GetMax
    {
        static void Main(string[] args)
        {
            // Write a method GetMax() with two parameters that returns the bigger of two integers. 
            //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
            int theOne = int.Parse(Console.ReadLine());
            int theTwo = int.Parse(Console.ReadLine());
            int theThree = int.Parse(Console.ReadLine());
            Console.WriteLine( GetTheMax(GetTheMax(theOne, theTwo), theThree) );
        }
        static int GetTheMax(int one, int two)
        {
            if (one.CompareTo(two) == 0)
            {
                return one;
            }
            else if (one.CompareTo(two) == 1)
            {
                return one;
            }
            return two;
        }
    }
}