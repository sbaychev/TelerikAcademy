using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillsInMatrixSizeB
{
    class FillsInMatrixSizeB
    {
        static void Main(string[] args)
        {
            //Write a program that fills and prints a matrix of size (n, n) as shown below: 
            //(examples for n = 4)
            // 1    8   9   16
            // 2    7   10  15
            // 3    6   11  14
            // 4    5   12  13
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 != 0)
                    {
                        matrix[row, col] = ( ((col + 1) * n ) - row);
                    }
                    else
                    {
                        matrix[row, col] = (row + 1) + (col * n);
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