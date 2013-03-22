using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoNumPrintGreater
{
    class TwoNumPrintGreater
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
            Console.Write("number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("\nnumber 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nThe Greater number is: {0}\n", (num1 > num2 ? num1 : num2));
        }
    }
}