using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillsInMatrixSizeA
{
    class FillsInMatrixSizeA
    {
        static void Main(string[] args)
        {
            //Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
            //1 5 9 13
            //
            //
            //
            //4 8   12  16
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int [n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        matrix[row, col] = (row + 1) + (col * n);
                    }
                    else
                    {
                        matrix[row, col] = (row + 1);
                    }       
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}