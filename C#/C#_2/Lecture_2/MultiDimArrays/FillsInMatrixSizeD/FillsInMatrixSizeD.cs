using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillsInMatrixSizeD
{
    class FillsInMatrixSizeD
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int first = 0;
            int k = 0;
            while (first < n * n)
            {

                for (int row = k; row < n - k; row++)
                {
                    matrix[k, row] = ++first;
                }
                for (int col = k + 1; col < n - k; col++)
                {
                    matrix[col, n - k - 1] = ++first;
                }
                for (int row = n - k - 2; row >= k; row--)
                {
                    matrix[n - k - 1, row] = ++first;
                }
                for (int col = n - k - 2; col >= k + 1; col--)
                {
                    matrix[col, k] = ++first;
                }
                k++;
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