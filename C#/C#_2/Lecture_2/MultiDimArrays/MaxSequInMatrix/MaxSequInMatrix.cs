using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequInMatrix
{
    class MaxSequInMatrix
    {
        static void Main(string[] args)
        {
            //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor 
            //elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal 
            //strings in the matrix. 
            // s    qq  s           s
            // pp   tt  s   ---->   s
            // pp   pp  s           s
            //
            int n = 4;//int.Parse(Console.ReadLine());
            string[,] matrix = new string [3, 4] {  {"ha",  "fifi", "ho",  "hi"},
                                                    {"fo",  "ha",   "ha",  "hi"},
                                                    {"xxx", "ho",   "ha",  "xx"} };
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;
            int bestDiagRightL = int.MinValue;
            int bestDiagLeftR = int.MinValue;

            int countRow = 1;
            int countCol = 1;
            int countDiagRightL = 1;
            int countDiagLeftR = 1;

            string longestRow = "";
            string longestCol = "";
            string longestDiagRightL = "";
            string longestDiagLeftR = "";
            #region row
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (  matrix[row, col].CompareTo(matrix[row, col - 1]) == 0)
                    {
                        countRow++;
                        if (countRow > bestRow)
                        {
                            longestRow = matrix[row, col];
                            bestRow = countRow;
                        }
                    }
                    else
                    {
                        countRow = 1;
                    }
                }
            }
            #endregion row
            #region col
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].CompareTo(matrix[row - 1, col]) == 0)
                    {
                        countCol++;
                        if (countCol > bestCol)
                        {
                            bestCol = countCol;
                            longestCol = matrix[row, col];
                        }
                    }
                    else
                    {
                        countCol = 1;
                    }
                }
            }
            #endregion col
            #region DiagRightL
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].CompareTo(matrix[row - 1, col - 1]) == 0)
                    {
                        countDiagRightL++;
                        if (countDiagRightL > bestDiagRightL)
                        {
                            bestDiagRightL = countDiagRightL;
                            longestDiagRightL = matrix[row, col];
                        }
                    }
                    else
                    {
                        countDiagRightL = 1;
                    }
                }
            }
            #endregion DiagRightL
            #region DiagLeftR
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col - 1].CompareTo(matrix[row - 1, col]) == 0)
                    {
                        countDiagLeftR++;
                        if (countDiagRightL > bestDiagLeftR)
                        {
                            bestDiagLeftR = countDiagLeftR;
                            longestDiagLeftR = matrix[row, col];
                        }
                    }
                    else
                    {
                        countDiagLeftR = 1;
                    }
                }
            }
            #endregion DiagLeftR
            int bestRowCol = Math.Max(bestRow, bestCol);
            int bestDiagRL = Math.Max(bestDiagRightL, bestDiagLeftR);
            int best = Math.Max(bestRowCol, bestDiagRL);
            if (best == bestRow)
            {
                Console.WriteLine("Line: {0} {1}", bestRow, longestRow);
            }
            else if (best == bestCol)
            {
                Console.WriteLine("Column: {0} {1}", bestCol, longestCol);
            }
            else if (best == bestDiagRightL)
            {
                Console.WriteLine("Diagonal Right-Left: {0} {1}", bestDiagRightL, longestDiagRightL);
            }
            else if (best == bestDiagLeftR)
            {
                Console.WriteLine("Diagonal Left-Right: {0} {1}", bestDiagLeftR, longestDiagLeftR);
            }         
        }
    }
}