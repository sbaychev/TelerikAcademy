using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexViaBinSearch
{
    class IndexViaBinSearch
    {
        static void Main(string[] args)
        {
//Write a program that finds the index of given element in a sorted array of integers by using 
//the binary search algorithm (find it in Wikipedia).
//Generally, to find a value in unsorted array, we should look through elements of an array one by one, until searched value is found.
//In case of searched value is absent from array, we go through all elements. In average, complexity of such an algorithm is proportional 
//to the length of the array.Situation changes significantly, when array is sorted. If we know it, random access capability can be 
//utilized very efficiently to find searched value quick. Cost of searching algorithm reduces to binary logarithm of the array length.
//For reference, log2(1 000 000) ≈ 20. It means, that in worst case, algorithm makes 20 steps to find a value in sorted array of a
//million elements or to say, that it doesn't present it the array.
//Algorithm
//Algorithm is quite simple. It can be done either recursively or iteratively:
//get the middle element;
//if the middle element equals to the searched value, the algorithm stops;
//otherwise, two cases are possible:
//searched value is less, than the middle element. In this case, go to the step 1 for the part of the array, before middle element.
//searched value is greater, than the middle element. In this case, go to the step 1 for the part of the array, after middle element.
//Now we should define, when iterations should stop. First case is when searched element is found. Second one is when subarray has no 
//elements. In this case, we can conclude, that searched value doesn't present in the array.
            int[] binsArray = { 5, 1, 4, 2, 3, 0, 71, 13, 22, 11, 44, 12, 55, 20, 77, 88, 
                              17, 47, 9, 6, 10, 23, 33, 99, 53, 14, 49, 95, 63, 91, 40, 26, 8, 7, 37 };
            int minNum = 0;
            int host = 0;
            for (int i = 0; i < binsArray.Length; i++)//brute force sort
            {
                minNum = i;
                for (int j = 0; j < binsArray.Length; j++)
                {
                    if (binsArray[j] > binsArray[minNum])
                    {
                        minNum = j;
                    }
                    host = binsArray[i];
                    binsArray[i] = binsArray[minNum];
                    binsArray[minNum] = host;
                }
            }
            //for (int i = 0; i < binsArray.Length; i++)
            //{
            //    Console.Write("{0} ", binsArray[i]);
            //}
            //Console.WriteLine();
            int lowestIndex = 0;
            int highestIndex = binsArray.Length - 1;
            int keyNum = 12; // the number that we are looking for in the Array
            int midpointNum = 0;
            while (lowestIndex <= highestIndex)//this whole binary search does the divide and conquer principle
            {
                midpointNum = lowestIndex + ((highestIndex - lowestIndex) / 2);

                if (keyNum == binsArray[midpointNum])
                {
                    Console.WriteLine("The value {0} has been found at index {1}", keyNum, midpointNum); // keyNum found
                    break;
                }
                else if (binsArray[midpointNum] < keyNum)
                {
                    lowestIndex = midpointNum + 1;
                }
                else if (binsArray[midpointNum] > keyNum)
                {
                    highestIndex = midpointNum - 1;
                }
                else
                {
                    Console.WriteLine("The given number has not been found");  // keyNum not found.
                }
            }       
        }
    }
}