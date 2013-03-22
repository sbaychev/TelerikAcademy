using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillsInMatrixSizeC
{
    class FillsInMatrixSizeC
    {
        static void Main(string[] args)
        {
            //7  11  14  16
            //4  8   12  15
            //2  5   9   13
            //1  3   6   10
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int first = 1;
            int k = 0;
            while (k <= n - 1)
            {
                for (int col = 0, row = n - k - 1; col <= k; col++, row++)
                {
                    matrix[col, row] = first++;
                }
                if (k < n - 1) k++;
                else break;
            }
            k--;
            while (k >= 0)
            {
                for (int col = n - 1 - k, row = 0; col <= n - 1; col++, row++)
                {
                    matrix[col, row] = first++;
                }
                k--;
            }
            Print(n, matrix);
        }
        static void Print(int n, int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(array[col, row]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}