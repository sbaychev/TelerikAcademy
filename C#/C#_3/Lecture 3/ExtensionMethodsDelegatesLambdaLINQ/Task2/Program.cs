using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement a set of extension methods for IEnumerable<T> 
            //that implement the following group functions: sum, product, min, max, average.
            int[] testNums = new int[5];
            for (int i = 0; i < testNums.Length; i++)
            {
                testNums[i] = i + 1;
            }

            Console.WriteLine(testNums.Sum());
            Console.WriteLine(testNums.Average());
            Console.WriteLine(testNums.Product());
            Console.WriteLine(testNums.Max());
            Console.WriteLine(testNums.Min());

        }
    }
}