using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingSystemPrintTheWeekDay
{
    class UsingSystemPrintTheWeekDay
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today. 
            //Use System.DateTime.
            Console.WriteLine("{0}", DateTime.Today.DayOfWeek);
        }
    }
}
