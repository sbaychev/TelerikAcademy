using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountTimesNumAppArr
{
    class CountTimesNumAppArr
    {
        static void Main(string[] args)
        {
            //Write a method that counts how many times given number appears in given array. 
            //Write a test program to check if the method is working correctly.
            int[] anArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; // we can use any array as long as the numApp value exists in the array
            int numApp = 9;
            int count = CountNumTimesInArr(numApp, anArray);
            Console.WriteLine(count);
        }
        static int CountNumTimesInArr(int num, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                    if (arr[i] == num)
                    {
                        counter++;
                    }
            }
            return counter;
        }
    }
}
