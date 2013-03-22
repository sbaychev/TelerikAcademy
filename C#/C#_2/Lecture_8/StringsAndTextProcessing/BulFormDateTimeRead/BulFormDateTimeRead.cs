using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace BulFormDateTimeRead
{
    class BulFormDateTimeRead
    {
        static void Main(string[] args)
        {
            //Write a program that reads a date and time given in the format: 
            //day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
            //(in the same format) along with the day of week in Bulgarian.
            Console.WriteLine("format: day.month.year hour:minute:second -> xx.xx.xxxx xx:xx:xx");
            string dateOne = Console.ReadLine();//"10.10.2010 21:01:10";         
            DateTime one = DateTime.ParseExact(dateOne, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            one = one.AddHours(6);
            one = one.AddMinutes(30);
            Console.WriteLine();
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine(String.Format("{0}, {1:dd.MM.yyyy HH:mm:ss}",  
                DateTimeFormatInfo.CurrentInfo.GetDayName(one.DayOfWeek),one));
        }
    }
}