using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForestRoadOld
{
    class ForestRoad
    {
            // Input 
            //The input data is being read from the console.
            //On the only line in the console you are given an integer number N, showing the width of the map. 
            //The map’s height is always 2*N - 1.
            //The input data will always be valid and in the format described. There is no need to check it explicitly.
            //Output 
            //The output data must be printed on the console.
            //You should print the whole map on the console. Use the symbol “*” (asterisk) to mark Geeko’s path and “.” (dot) 
            //to illustrate the trees.
            //Constraints
            //•	The number N is a positive integer between 2 and 79, inclusive.
            //•	Allowed working time for your program: 0.25 second.

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] dot = { ".", ".", ".", ".", "." };
            Console.WriteLine(dot);
            for (int i = 0; i < n + 1; i++)
            {

            }
            for (int i = 0; i < n - 1; i++)
            {
                
            }
        }
    }
}
