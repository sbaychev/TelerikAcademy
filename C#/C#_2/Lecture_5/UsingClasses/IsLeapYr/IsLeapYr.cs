using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYr
{
    class IsLeapYr
    {
        static void Main(string[] args)
        {
            //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

                     int currentYear = int.Parse(Console.ReadLine());
                     //bool leapYear = false;                     
                     Console.WriteLine(DateTime.IsLeapYear(currentYear));
                     //if (currentYear % 400 == 0)//http://en.wikipedia.org/wiki/Leap_year
                     //{
                     //    leapYear = true;
                     //}
                     //else if (currentYear % 100 == 0)
                     //{
                     //    leapYear = false;
                     //}
                     //else if (currentYear % 4 == 0)
                     //{
                     //    leapYear = true;
                     //}
                     //else
                     //{
                     //    leapYear = false;
                     //}
                     //Console.WriteLine(leapYear);
        }

    }
}