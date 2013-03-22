using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class WorkDaysCalcStaEnd
    {
        static void Main(string[] args)
        {
            //Write a method that calculates the number of workdays between today and 
            //given date, passed as parameter. Consider that workdays are all days from 
            //Monday to Friday except a fixed list of public holidays specified preliminary as array.

                DateTime today = DateTime.Today;
                Console.WriteLine("the input order is: mm/dd/yyyy");
                DateTime someDay = DateTime.Parse(Console.ReadLine());// the input order is: (mm/dd/yyyy)
                DateTime[] holidays = new DateTime[] //official Bulgarian Holidays
                {
                    new DateTime(DateTime.Now.Year, 12, 25),
                    new DateTime(DateTime.Now.Year, 12, 24),
                    new DateTime(DateTime.Now.Year, 12, 26),
                    new DateTime(DateTime.Now.Year, 1, 1),
                    new DateTime(DateTime.Now.Year, 3, 3),
                    new DateTime(DateTime.Now.Year, 5, 1),
                    new DateTime(DateTime.Now.Year, 5, 2),
                    new DateTime(DateTime.Now.Year, 5, 3),
                    new DateTime(DateTime.Now.Year, 5, 4),
                    new DateTime(DateTime.Now.Year, 5, 5),
                    new DateTime(DateTime.Now.Year, 5, 24),
                    new DateTime(DateTime.Now.Year, 9, 6),
                    new DateTime(DateTime.Now.Year, 9, 22),
                    
                };
                Console.WriteLine(Workdays(today, someDay, holidays));
        }
        static int Workdays(DateTime firstDay, DateTime lastDay, params DateTime[] offdays)
        {
            firstDay = firstDay.Date;
            lastDay = lastDay.Date;
            if (firstDay > lastDay)
                throw new ArgumentException("Incorrect last day " + lastDay);

            TimeSpan span = lastDay - firstDay;
            int workDays = span.Days + 1;
            int fullWeekCount = workDays / 7;
            // find out if there are weekends during the time exceedng the full weeks
            if (workDays > fullWeekCount * 7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday
                                                            ? 7 : (int)firstDay.DayOfWeek;
                int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Sunday
                                                            ? 7 : (int)lastDay.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        workDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        workDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    workDays -= 1;
            }

            // subtract the weekends during the full weeks in the interval
            workDays -= fullWeekCount + fullWeekCount;

            // subtract the number of bank holidays during the time interval
            foreach (DateTime bankHoliday in offdays)
            {
                DateTime bh = bankHoliday.Date;
                if (firstDay <= bh && bh <= lastDay)
                    --workDays;
            }
            return workDays;
        }
    }