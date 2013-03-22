using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5Pillars
{
    class Problem5Pillars
    {
//You are given a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7. These numbers represent a square grid 
//consisting of 8 lines and 8 columns. Each cell of the grid could either be empty or full. The first line is represented by the bits 
//of n0, the second – by the bits of n1 and so on, and the last line is represented by the bits of n7. Each bit with value 1 denotes 
//a full cell and each bit with value 0 denotes an empty cell. The lines are numbered from the first (top) to the last (bottom) with
//the numbers 0, 1, …, 7. The columns are numbered from right to left with the indices 0, 1, …, 7. The figure shows a square grid and 
//its representation by a sequence of 8 numbers n0, n1, …, n7:
// 7	6	5	4	3	2	1	0	
//0									n0 = 0
//1		■							n1 = 64
//2									n2 = 0
//3					■				n3 = 8
//4									n4 = 0
//5					■	■			n5 = 12
//6	■	■	■						n6 = 224
//7									n7 = 0
//We are allowed to put a vertical pillar over any of the columns in the grid. Pillars split the grid into two sides (left and right) 
//and the column holding the pillar is ignored. Write a program that finds the leftmost column where the pillar can be put so that the
//full cells on the left side and on the right side are equal number. For example at the figure if we put the pillar at column 5, it 
//will split the grid into two sides and both sides will have exactly 3 full cells.
//Input
//The input data should be read from the console.
//There will be exactly 8 lines each holding the integer numbers n0, n1, …, n7.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//If a pillar splitting the grid into two vertical sides each holding the same number of full cells exists, print its column index on 
//the first line and the number of full cells in each of the sides. If multiple pillars can do the job, print only the leftmost. 
//If no such pillar exists, print the string "No" on the console (just one line holding the word "No").
//Constraints
//•	The numbers n0, n1, …, n7 are positive integers in the range [0…255].

        static void Main(string[] args)
        {
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());

            int one0, one1, one2, one3, one4, one5, one6, one7;
            one0 = one1=  one2=  one3=  one4=  one5=  one6=  one7= 0;
            for (int i = 0; n0 != 0;i++)
            {
                if ((n0 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n0 >>= 1;
            }

            for (int i = 0; n1 != 0; i++)
            {
                if ((n1 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n1 >>= 1;
            }

            for (int i = 0; n2 != 0; i++)
            {
                if ((n2 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n2 >>= 1;
            }

            for (int i = 0; n3 != 0; i++)
            {
                if ((n3 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n3 >>= 1;
            }

            for (int i = 0; n4 != 0; i++)
            {
                if ((n4 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n4 >>= 1;
            }

            for (int i = 0; n5 != 0; i++)
            {
                if ((n5 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n5 >>= 1;
            }

            for (int i = 0; n6 != 0; i++)
            {
                if ((n6 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n6 >>= 1;
            }

            for (int i = 0; n7 != 0; i++)
            {
                if ((n7 & 1U) == 1)
                {
                    if (i == 0)
                    {
                        one0++;
                    }
                    if (i == 1)
                    {
                        one1++;
                    }
                    if (i == 2)
                    {
                        one2++;
                    }
                    if (i == 3)
                    {
                        one3++;
                    }
                    if (i == 4)
                    {
                        one4++;
                    }
                    if (i == 5)
                    {
                        one5++;
                    }
                    if (i == 6)
                    {
                        one6++;
                    }
                    if (i == 7)
                    {
                        one7++;
                    }
                }
                n7 >>= 1;
            }
            int sumAllCells = one0 + one1 + one2 + one3 + one4 + one5 + one6 + one7;
            if (sumAllCells == 64)
            {
                
            }
        }
    }
}

            //int num0 = Int32.Parse(Console.ReadLine());
            //int num1 = Int32.Parse(Console.ReadLine());
            //int num2 = Int32.Parse(Console.ReadLine());
            //int num3 = Int32.Parse(Console.ReadLine());
            //int num4 = Int32.Parse(Console.ReadLine());
            //int num5 = Int32.Parse(Console.ReadLine());
            //int num6 = Int32.Parse(Console.ReadLine());
            //int num7 = Int32.Parse(Console.ReadLine());

            //// Solve the task
            //int bestCount = Int32.MinValue;
            //int bestIndex = Int32.MinValue;
            //for (int index = 0; index <= 7; index++)
            //{
            //    int leftCount = 0;
            //    for (int leftIndex = index + 1; leftIndex <= 7; leftIndex++)
            //    {
            //        leftCount += (num0 >> leftIndex) & 1;
            //        leftCount += (num1 >> leftIndex) & 1;
            //        leftCount += (num2 >> leftIndex) & 1;
            //        leftCount += (num3 >> leftIndex) & 1;
            //        leftCount += (num4 >> leftIndex) & 1;
            //        leftCount += (num5 >> leftIndex) & 1;
            //        leftCount += (num6 >> leftIndex) & 1;
            //        leftCount += (num7 >> leftIndex) & 1;
            //    }

            //    int rightCount = 0;
            //    for (int rightIndex = 0; rightIndex <= index - 1; rightIndex++)
            //    {
            //        rightCount += (num0 >> rightIndex) & 1;
            //        rightCount += (num1 >> rightIndex) & 1;
            //        rightCount += (num2 >> rightIndex) & 1;
            //        rightCount += (num3 >> rightIndex) & 1;
            //        rightCount += (num4 >> rightIndex) & 1;
            //        rightCount += (num5 >> rightIndex) & 1;
            //        rightCount += (num6 >> rightIndex) & 1;
            //        rightCount += (num7 >> rightIndex) & 1;
            //    }

            //    if (leftCount == rightCount)
            //    {
            //        bestCount = leftCount;
            //        bestIndex = index;
            //    }
            //}

            //if (bestCount != Int32.MinValue)
            //{
            //    Console.WriteLine(bestIndex);
            //    Console.WriteLine(bestCount);
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}