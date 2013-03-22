using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSumAvrgProdMinMax
{
    class CalcSumAvrgProdMinMax
    {
        static void Main(string[] args)
        {
            //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
            //Use variable number of arguments.

            CalcMinMaxSumAvgSum(1,2,3);
        }
        static void CalcMinMaxSumAvgSum(params int[] elements)
        {
            long sum = 0;
            long max = elements.Max();
            long min = elements.Min();
            long product = 1;
            foreach (int element in elements)
            {               
                sum += element;
                product *= element;
            }
            Console.WriteLine("sum = {0}\nmax = {1}\nmin = {2}\naverage = {3}\nproduct = {4}", 
                                sum, max, min, (sum / (elements.Length)), product);
            return;
        }
    }
}