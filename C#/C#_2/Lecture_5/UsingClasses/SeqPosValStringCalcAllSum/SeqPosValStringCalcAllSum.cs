using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeqPosValStringCalcAllSum
{
    class SeqPosValStringCalcAllSum
    {
        static void Main(string[] args)
        {
        //You are given a sequence of positive integer values written into a string, 
        //separated by spaces. Write a function that reads these values from given string
        //and calculates their sum. Example: string = "43 68 9 23 318"  result = 461
            string str = "43 68 9 23 318";
            int sumOfStr = ReadStrAndSumIt(str);
            Console.WriteLine("result = {0}", sumOfStr);
        }
        static int ReadStrAndSumIt(string ofNums)
        {
            string[] nums = ofNums.Split(' ');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += int.Parse(nums[i]);
            }
            return sum;
        }
    }
}
