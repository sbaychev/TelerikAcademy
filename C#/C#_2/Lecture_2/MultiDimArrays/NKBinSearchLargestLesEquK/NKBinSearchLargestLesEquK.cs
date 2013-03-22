using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NKBinSearchLargestLesEquK
{
    class NKBinSearchLargestLesEquK
    {
        static void Main(string[] args)
        {
            //Write a program, that reads from the console an array of N integers and an 
            //integer K, sorts the array and using the method Array.BinSearch() finds the 
            //largest number in the array which is ≤ K. 
            //string strIntArr =  "1 3 10 5 15 20";
            string strIntArr = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string [] numbIntArr = strIntArr.Split(
                        new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nIntsArr = new int[numbIntArr.Length];
            for (int i = 0; i < numbIntArr.Length; i++)
            {
                //Console.WriteLine(numbIntArr[i]);
                int value = Int32.Parse(numbIntArr[i]);
                nIntsArr[i] = value;
            }
            bubbleSort1(ref nIntsArr);
            //for (int i = 0; i < preFinIntArr.Length; i++)
            //{
            //    Console.Write("{0} ",preFinIntArr[i]);
            //}
            Console.WriteLine();
            Console.WriteLine("The index of the largest number in the array which is ≤ than {1} is {0}", 
                BinSearch(ref nIntsArr, k), k);
        }
        public static void bubbleSort1(ref int[] x)
        {
            bool exchanges;
            do
            {
                exchanges = false;
                for (int i = 0; i < x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        // Exchange elements
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        exchanges = true;
                    }
                }
            } while (exchanges);
        }
        public static int BinSearch(ref int[] x, int searchValue)
        {
            // Returns index of searchValue in sorted array x, or -1 if not found
            int left = 0;
            int right = x.Length;
            return binarySearch(ref x, searchValue, left, right);
        }
        public static int binarySearch(ref int[] x, int searchValue, int left, int right)
        {
            int mid = (left + right) >> 1;
            if (right < left)
            {
                return x[mid];
            }
            //Console.WriteLine("{0}", mid);
            if (searchValue >= x[mid])
            {
                //if (x[mid] > max) { max = x[mid]; }
                return binarySearch(ref x, searchValue, mid + 1, right);
            }
            else if (searchValue < x[mid])
            {
                //if (x[mid] > max) { max = x[mid];  }
                return binarySearch(ref x, searchValue, left, mid - 1);
            }
            else
            {
                return mid;
            }
        }
    }
}