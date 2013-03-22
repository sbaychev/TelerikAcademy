using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NandKVariations
{
    class NandKVariations
    {
        static int[] variation;
        static int variationPosition;

        static void PrintVariations(int left, int total, int n)
        {
            if (left == 0)
            {
                for (int i = 0; i < total; ++i)
                {
                    if (i != 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(variation[i]);
                }
                Console.Write("\n");
            }
            if (left > 0)
            {

                for (int i = 1; i <= n; ++i)
                {
                    variation[variationPosition++] = i;
                    PrintVariations(left - 1, total, n);
                    variationPosition--;
                }
            }
        }
        static void Main(string[] args)
        {
        //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
        //    Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}            
            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());

            //variation = new int[k];

            //PrintVariations(k, k, n);
        }
    }
}
