using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3SandGlass
{
    class Problem3SandGlass
    {
//He would catch the witches and throw them into a sand-glass (the only prison a witch cannot escape from). Unfortunately, 
//he is running out of sand-glasses. Help Gwenogfryn catch all witches by making your own sand-glasses.
//Input
//The input data should be read from the console.
//You have an integer number N (always odd number) showing the height of the sand clock.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//You should print the hourglass on the console. Each row can contain only the following characters: “.” (dot) and 
//“*” (asterisk). As shown in the example: the middle row must contain only one ‘*’ and all other symbols must be “.”. 
//Every next row (up or down from the middle one) must contain the same number of ‘*’ as the previous one plus two. 
//You should only use “.” to fill-in the rows, where necessary.
//Constraints
//•	The number N will be a positive integer number between 3 and 101, inclusive.

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i < N/2 + 1)
                    {
                        if (j >= i && j <= N + 1 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    if (i == N/2 + 1)
                    {
                        if (j == N/2 + 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    if (i > N / 2 + 1)
                    {
                        if (j <= i && j >= N + 1 - i)
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