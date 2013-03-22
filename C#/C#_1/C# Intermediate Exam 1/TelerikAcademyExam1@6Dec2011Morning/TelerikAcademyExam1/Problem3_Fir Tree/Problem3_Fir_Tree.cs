﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3_Fir_Tree
{
    class Problem3_Fir_Tree
    {
//Christmas Eve is coming so even programmers have to prepare!
//In the spirit of the event your task is to write a program that prints a fir tree to the console.
//The format of the tree is shown in the examples bellow.
//Input
//The input data should be read from the console.
//On the only input line you have an integer number N, showing the height of the tree.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print the fir tree on the console. Each row contains only characters "." (point)  or "*" (asterisk).
//The first row should have exactly one "*" in the middle (that is the top of the tree) and each of the next lines two more.
//The last line should have exactly one asterisk in the middle, showing the stem of the tree.
//Constraints
//•	The number N is a positive integer between 4 and 100, inclusive.

        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (2 * N) - 3; j++)
                {
                    if (i == N - 1)
                    {
                        if (j == ((2 * N) - 3) / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    if (i != N - 1)
                    {                                            
                        if (j >= N - 2 - i && j <= N - 2 + i)
                        {
                                Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }                 
                }
                Console.WriteLine();
            }
        }
    }
}