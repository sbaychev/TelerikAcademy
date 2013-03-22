using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostFreqNumInArr
{
    class MostFreqNumInArr
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in an array. 
            //Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
            int[] anArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //{ 4, 9, 1, 1, 9, 4, 2, 9, 3, 9, 4, 9, 4, 1, 2, 3 };
            int minNum = 0;
            int hostNum = 0;
            int curMaxSum = 0;
            int counter = 0;
            int highestCounter = 0;
            int mostFreqNum = 0;
            for (int i = 0; i < anArray.Length; i++)// brute force sort
            {
                minNum = i;
                for (int j = 0; j < anArray.Length; j++)
                {
                    if (anArray[j] > anArray[minNum])
                    {
                        minNum = j;
                    }
                    hostNum = anArray[i];
                    anArray[i] = anArray[minNum];
                    anArray[minNum] = hostNum;
                }
            }
            for (int f = 0; f < anArray.Length; f++)
            {
                if (curMaxSum != counter * anArray[f])// making sure that the next number is the same value as the previous
                {                                       //if not obviously we do zero down everything
                    counter = 0;
                    curMaxSum = 0;
                }

                curMaxSum += anArray[f];
                counter++;

                    if (counter > highestCounter)
                    {
                        highestCounter = counter;
                        mostFreqNum = anArray[f];//saves the first number that gets to have the highest count
                    }                  
            }
            Console.WriteLine("{0} ({1} times)", mostFreqNum, highestCounter);
        }
    }
}