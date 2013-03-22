using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoPosIntRemDev
{
    class TwoPosIntRemDev
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
            //that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2
            Console.Write("number 1: ");
            int varNumOne = int.Parse(Console.ReadLine());
            Console.Write("\nnumber 2: ");
            int varNumTwo = int.Parse(Console.ReadLine());
            int smaller = varNumOne > varNumTwo ? varNumOne : varNumTwo;
            int varNumberP = 0;
            for (int i = 0; i <= Math.Abs(varNumOne - varNumTwo); i++)
			{
                Console.WriteLine(i);
                if ((smaller + i) % 5 == 0)
                {
                    varNumberP++;
                }
			}
            Console.WriteLine("\np({0},{1}) = {2}\n", varNumOne, varNumTwo, varNumberP);
        }
    }
}