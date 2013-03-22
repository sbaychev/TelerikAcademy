using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3_Trapezoid
{
    class Problem3_Trapezoid
    {
    //Write a program that prints on the console the border of a trapezoid by given number N.
    //The width of the top side of the trapezoid must be exactly N.
    //The width of the bottom side of the trapezoid must be exactly 2 * N.
    //The height of the trapezoid must be exactly N + 1.
    //Also the top right and the bottom right angle of the trapezoid must be equal to 90 degrees.
    //See the examples bellow.
    //Input
    //The input data is being read from the console.
    //On the only line in the console you are given an integer number N, showing the width of the smallest trapezoid side.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console.
    //You must write the border of the described trapezoid on the console.
    //Use the symbol “*” (asterisk) to mark the border of the trapezoid.
    //Use the symbol “.” (dot) to illustrate the empty spaces outside and inside the trapezoid.
    //Constraints
    //•	The number N is a positive integer between 3 and 39, inclusive.

        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            for (int i = 0; i < N + 1; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 2 * N; j++)
                    {
                        if (j >= N)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        } 
                    }
                }
                if (i > 0 && i < N)
                {
                    for (int k = 0; k < 2 * N - 1; k++)
                    {
                        if (k == N - i)
                        {
                            Console.Write("*");
                        }
                        if (k == 2 * N - 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                if (i == N)
                {
                    for (int t = 0; t < 2 * N; t++)
                    {
                        Console.Write("*");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}