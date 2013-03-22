using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSignOfMultThreeNum
{
    class TheSignOfMultThreeNum
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign of the product of three real numbers without calculating it. Use a sequence 
            //of if statements.
            Console.WriteLine("Please enter three real numbers (on separate lines).");
            double firstDouble = double.Parse(Console.ReadLine());
            double secondDouble = double.Parse(Console.ReadLine());
            double thirdDouble = double.Parse(Console.ReadLine());
            if (ProductIsNegative(firstDouble, secondDouble, thirdDouble))
            {
                Console.Write("\nThe sign of the numbers'product is Positive\n");
            }
            else
            {
                Console.Write("\nThe sign of the numbers'product is Negative\n");
            }
        }

        private static bool ProductIsNegative(double firstDouble, double secondDouble, double thirdDouble)
        {
            return (firstDouble > 0 && secondDouble > 0 && thirdDouble > 0) || (firstDouble < 0 && secondDouble < 0 && thirdDouble > 0) || (firstDouble < 0 && secondDouble > 0 && thirdDouble < 0) || (firstDouble > 0 && secondDouble < 0 && thirdDouble < 0);
        }
    }
}