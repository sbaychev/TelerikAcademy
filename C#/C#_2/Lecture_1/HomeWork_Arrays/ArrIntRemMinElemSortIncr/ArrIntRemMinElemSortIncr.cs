using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrIntRemMinElemSortIncr
{
    class ArrIntRemMinElemSortIncr
    {
    //* Write a program that reads an array of integers and removes from it a minimal number of elements in such 
    //way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example: 
    //{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

    static void Main(string[] args)
    {        
        int n = int.Parse(Console.ReadLine());
        List<int> intArr = new List<int>();
        List<int> sortedArr = new List<int>();
        int maxSubsetLenght = 0;

        for (int i = 0; i < n; i++)
        {
            intArr.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 1; i <= (int)Math.Pow(2, n) - 1; i++)
        {
            int tempSubsetLenght = 0;
            List<int> tempArr = new List<int>();

            for (int j = 1; j <= n; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)// the idea is to get all possible sub arrays of the given
                {
                    tempArr.Add(intArr[j - 1]);
                    tempSubsetLenght++;
                }
            }

            if ((tempSubsetLenght > maxSubsetLenght) && (CheckAscending(tempArr)))//here we test the above added for ascending order
            {
                sortedArr = tempArr;
                maxSubsetLenght = tempSubsetLenght;
            }
        }//we get to pick the first subarray that has the longest ascended order of integers
        Console.Write("{ ");
        for (int i = 0; i < sortedArr.Count; i++)
        {
            Console.Write("{0} ",sortedArr[i]);
        }
        Console.Write("}");
        Console.WriteLine();
    }
    static bool CheckAscending(List<int> list)
    {
        bool ascending = true;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                ascending = false;
            }
        }
        return ascending;
    }
  }
}