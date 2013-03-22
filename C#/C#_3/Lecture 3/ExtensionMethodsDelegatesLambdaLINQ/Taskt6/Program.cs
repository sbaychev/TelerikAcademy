using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskt6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            int[] testNums = new int[50];
            for (int i = 0; i < testNums.Length; i++)
            {
                testNums[i] = i + 1;
            }
            // lambda expressions program that prints from given array of integers all numbers that are divisible by 7 and 3. 

            var divisNums = testNums.Where(x => x % 21 == 0); //divisible by 7 and 3 

            // LINQ program that prints from given array of integers all numbers that are divisible by 7 and 3. 

            //var divisNums =
            //from num in testNums
            //where num % 21 == 0
            //select num;

            foreach (var num in divisNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}