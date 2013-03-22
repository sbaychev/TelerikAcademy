using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiveIntegerNumbers
{
    class FiveIntegerNumbers
    {
        // all subsets of given set 
        //static void numbcomb(int[] arr, int subSum)
        //{
        //    int numOfSubSets = (int)Math.Pow(2, arr.Length); // number of subsets (2^n)
        //    int[,]result = new int[numOfSubSets, arr.Length]; // array with subsets as elements

        //    for (int i = 0; i < numOfSubSets; i++) // filling "result"....
        //    {
        //        for (int j = 0; j < arr.Length; j++)  // 0,1,2 (for n=3)
        //        {
        //            int t = (int)Math.Pow(2, j); // 1,2,4 (for n=3)
        //            if ((i & t) != 0)  
        //            // i can be:
        //            // 000,001,010,011,100,101,110,111
        //            // t can be: 001,010,100
        //            {
        //                if ((result[i, j] += arr[j]) == 0)
        //                {
        //                    for (int f = 0; f < arr.Length; f++)
        //                    {
        //                        Console.Write("{0} ", result[i, f]);
        //                    }
        //                }
        //            } // add to subset
        //        }
        //        //Console.Write("{0}: ", i);// write subset number
        //        //Console.WriteLine(result[i]);//write subset itself
        //    }
        //}
        static void Main(string[] args)
        {
            //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
            //Example: 3, -2, 1, 1, 8  1+1-2=0.

            string readSum = Console.ReadLine();
            long sum = long.Parse(readSum);

            string readNNumbers = Console.ReadLine();
            byte nNumbers = byte.Parse(readNNumbers);

            long[] sequenceOfNumbers = new long[nNumbers];

            for (int i = 0; i < nNumbers; i++)
            {
                string readNumber = Console.ReadLine();
                long number = long.Parse(readNumber);

                sequenceOfNumbers[i] = number;
            }

            int counter = 0;
            int countCurrentLengthOfSequences = 0;

            decimal currentNumber = 0;
            decimal result = 0;

            for (int j = countCurrentLengthOfSequences; j < sequenceOfNumbers.Length; j++)
            {
                result = sequenceOfNumbers[j];

                if (result == sum)
                {
                    counter++;
                }
            }

            int currentLengthOfSequences = 1;
            int nextIndex = 0;
            int length = sequenceOfNumbers.Length;

            if (length > 1)
            {
                while (true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        result = 0;
                        currentNumber = 0;
                        countCurrentLengthOfSequences = 0;

                        if ((countCurrentLengthOfSequences < currentLengthOfSequences) &&
                            ((i + currentLengthOfSequences) < length))
                        {
                            for (int x = i; x < i + currentLengthOfSequences; x++)
                            {
                                currentNumber = currentNumber + sequenceOfNumbers[x];
                                countCurrentLengthOfSequences++;
                                nextIndex = x;
                            }
                        }
                        else
                        {
                            break;
                        }

                        nextIndex++;

                        if (nextIndex < length)
                        {
                            for (int j = nextIndex; j < length; j++)
                            {
                                result = currentNumber + sequenceOfNumbers[j];

                                if (result == sum)
                                {
                                    counter++;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    currentLengthOfSequences++;

                    if (currentLengthOfSequences == length)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}