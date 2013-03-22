using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckInExprBrackArCorr
{
    class CheckInExprBrackArCorr
    {
        static void Main(string[] args)
        {
          //Write a program to check if in a given expression the brackets are put correctly.
         //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
            string expression = Console.ReadLine();//")(a+b))";
            char openB = '(';
            int openBracketCount = 0;
            char closeBracketCount = ')';
            int closeBCount = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if ( expression[i].Equals(openB) )
                {
                    openBracketCount++;
                }
                else if (expression[i].Equals(closeBracketCount) )
                {
                    closeBCount++;
                }
            }
            if ( (openBracketCount % 2 != 0) || (closeBCount % 2 != 0))
            {
                Console.WriteLine("incorrect expression");
            }
            else
            {
                Console.WriteLine("correct expression");
            }
        }
    }
}