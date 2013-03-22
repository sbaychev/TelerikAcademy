using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTimesNumberInArr
{
    class CountTimesNumberInArr
    {
        static void Main(string[] args)
        {
            //Write a method that counts how many times given number appears in given array.
            //Write a test program to check if the method is working correctly.          
           
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());//12;
            int[] arr = new int[n];//{ 1, 12, 3, 4, 5, 6, 1, 8, 3, 4, 1, 6, 2, 3, 5, 44, 13, 56, 12, 3 };
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            CountTimesNumInArr(number, arr);
        }
        static void CountTimesNumInArr(int num, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine();
           Console.WriteLine("{0} times",count);
        }
    }
}
