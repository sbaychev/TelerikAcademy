using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethValidatesIfIntInRangeElseExcept
{
    class MethValidatesIfIntInRangeElseExcept
    {
        static void Main(string[] args)
        {
        //Write a method ReadNumber(int start, int end) that enters an integer number in 
        //given range [start…end]. If an invalid number or non-number text is entered, the 
        //method should throw an exception. Using this method write a program that enters 
        //10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
            
           ReadNumber(1,100);//Console.ReadLine()
        }
        static void ReadNumber(int start, int end)
        {
            int[] nums = new int[10];
            string[] str = new string[10];
            str[0] = Console.ReadLine();
            bool pass = int.TryParse(str[0], out nums[0]);
            if (pass == false || (nums[0] < start || nums[0] > end))
            {
                Console.WriteLine("Invalid number or Non-Number text is entered");
            }
            for (int i = 1; i < 10; i++)
            {
                str[i] = Console.ReadLine();
                bool passI = int.TryParse(str [i], out nums [i]);
                if (passI == false || (nums[i] < start || nums[i] > end) || nums[i] < nums[i - 1])
                {
                    Console.WriteLine("Invalid number or Non-Number text is entered");
                }
            }
        }
    }
}