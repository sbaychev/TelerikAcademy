using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfSubArrElemSumExist
{
    class IfSubArrElemSumExist
    {
        static void Main(string[] args)
        {
            //* We are given an array of integers and a number S. Write a program to find if there exists a subset of 
            //the elements of the array that has a sum S. Example: arr = {2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)
            //int[] givIntArr = { 2, 1, 2, 4, 3, 5, 2, 6 };          
            int n = int.Parse(Console.ReadLine()); // the number of members in the array
            int sum = int.Parse(Console.ReadLine()); //14;
            List<int> intArr = new List<int>();
            List<int> finalArr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                intArr.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 1; i <= (int)Math.Pow(2, n) - 1; i++)
            {
                List<int> tempArr = new List<int>();

                for (int j = 1; j <= n; j++)
                {
                    if (((i >> (j - 1)) & 1) == 1)// the idea is to get all possible sub arrays of the given
                    {
                        tempArr.Add(intArr[j - 1]);
                    }
                }               
                if (tempArr.Sum() == sum)
                {
                    finalArr = tempArr;
                    //break;
                }
            }
            Console.Write("yes (");
            for (int i = 0; i < finalArr.Count; i++)
            {
                if (i == finalArr.Count - 1)
                {
                    Console.Write("{0}", finalArr[i]);
                }
                else
                {
                    Console.Write("{0}+", finalArr[i]);
                }              
            }
            Console.Write(") equals {0}", sum);
            Console.WriteLine();
        }
    }
}