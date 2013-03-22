using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubArraySumIfPresent
{
    class SubArraySumIfPresent
    {
        static void Main(string[] args)
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). 
            //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
            int[] intArr = { 4, 3, 1, 7, 2, 5, 8 };
            int sumS = 11;
            int curHighestSum = 0;
            int highest = 0;
            int numCheck = 0; //here are stored the number of digits/numbers that have been summed up to give us the sumS
            int times = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                curHighestSum += intArr[i]; // we are summing up each member of the array into curHighestSum
                numCheck++;
                Console.WriteLine(curHighestSum);
                if (curHighestSum == sumS) //first we are checking, if we have reached our desired quota of == sumS; and if so
                {                         //we are recording the highest current index "i" of the array and we are done
                    highest = i;
                    break;
                }
                if (curHighestSum > sumS) //here if the so far summed up digits/numbers are above the set up limit, we are
                {                        //moving one index ahead in the array and start again to find the proper sequence that sums up to sumS                                        //and in the process we nullify everything to the so far mentioned
                    times++;            //counts the number of times we have gone above the desired sum
                    curHighestSum = 0;                   
                    i = times - 1;
                    numCheck = 0;
                }
            }
            int count = 1;//starting the count at one because of the starting 0 index of the array
            Console.Write("{ ");
            do
            {
                Console.Write(intArr[(highest - numCheck) + count]);
                Console.Write(" ");
                count++;
            } while (count <= numCheck);
            Console.Write("}");
            Console.WriteLine();
        }
    }
}