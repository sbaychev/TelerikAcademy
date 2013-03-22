using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntValuesSummed
{
    class StringIntValuesSummed
    {
        static void Main(string[] args)
        {
            //You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
		    //string = "43 68 9 23 318"  result = 461
            string posVal = Console.ReadLine();//"43 68 9 23 318";
            int[] intArr = posVal.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int sum = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }
            Console.WriteLine(sum);
        }
    }
}