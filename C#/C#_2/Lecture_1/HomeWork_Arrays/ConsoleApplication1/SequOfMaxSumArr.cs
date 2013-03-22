using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequOfMaxSumArr
{
    class SequOfMaxSumArr
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the sequence of maximal sum in a given array. Example:
             * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
	        Can you do it with only one loop (with single scan through the elements of the array)?
            Kadane's algorithm*/
            int[] givenArr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            //Console.WriteLine(givenArr.Length);
            //int sum = givenArr.Sum();
            //Console.WriteLine(sum);
            int lowestIndex = 0;
            int highestIndex = 0;
            int maxSubSum = 1 << 31;//we are making sure to take the lowest possible int value for comparison, as we will see
            int curMaxSubSum = 0;  //below that we are using it to find the greatest sum of elements
            int curLowIndex = 0;
            for (int i = 0; i < givenArr.Length; i++)
            {
                curMaxSubSum += givenArr[i];
                if (curMaxSubSum > maxSubSum)
                {
                    //in most cases == true, but we have to make sure that the negative values are properly orderd
                    maxSubSum = curMaxSubSum;
                    lowestIndex = curLowIndex; //the "global" sort to speak variable 'lowest' takes the curLowIndex
                    highestIndex = i;       //the "global" sort to speak variable 'highest' takes the i 's current ittration digit
                    //the "global" sort to speak variable 'maxSubSum' takes the current maximum
                }                            //value of the given sub array that has the highest value
                if (curMaxSubSum < 0) //if we go into negative value for the maximum sum of the given sub array, we nulify
                {                    //the variable that takes the above described and move ahead with +1 the current lowest index value of the sub array
                    curMaxSubSum = 0;
                    curLowIndex = i + 1;
                }
            }
            int count = 0;
            Console.Write("{ ");
            do
            {
                Console.Write(givenArr[lowestIndex + count]);
                Console.Write(" ");
                count++;
            } while (count <= highestIndex - lowestIndex);
            Console.Write("}");
            Console.WriteLine();
        }
    }
}