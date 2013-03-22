using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nNumberAndNsumNumbers
{
    class nNumberAndNsumNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.*/
            Console.Write("Please Enter a Number: ");
            int varN = int.Parse(Console.ReadLine());
            int intVarSum = 0;
            for (int i = 0; i < varN; i++)
            {
                Console.Write("\nPlease Enter the {0} additional number/ s: ", i+1);
                int varNumber = int.Parse(Console.ReadLine());
                intVarSum = intVarSum + varNumber;
            }
            Console.WriteLine("\nThe sum of the additionally entered {0} numbers is: {1}\n", varN, intVarSum);
        }
    }
}