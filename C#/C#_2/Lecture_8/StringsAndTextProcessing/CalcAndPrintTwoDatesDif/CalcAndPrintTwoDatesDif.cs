using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalcAndPrintTwoDatesDif
{
    class CalcAndPrintTwoDatesDif
    {
        static void Main(string[] args)
        {
            //Write a program that reads two dates in the format: day.month.year and 
            //calculates the number of days between them. Example:
            Console.WriteLine("format: day.month.year -> xx.xx.xxxx -> must be in this exact format");
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();
            DateTime one = DateTime.ParseExact(dateOne, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime two = DateTime.ParseExact(dateTwo, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("{0} days",Math.Abs((one - two).Days));
        }
    }
}