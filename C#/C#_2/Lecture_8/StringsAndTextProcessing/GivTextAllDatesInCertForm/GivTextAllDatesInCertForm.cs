using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace GivTextAllDatesInCertForm
{
    class GivTextAllDatesInCertForm
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all dates that match the
            //format DD.MM.YYYY. Display them in the standard date format for Canada.
            Console.WriteLine("format: day.month.year -> xx.xx.xxxx");
            string datesText = Console.ReadLine();  //"10.10.2010, 10.10.2011, 10.10.2012, 10.10.2013";
            List<string> dates = new List<string>();
            //DateTime one = DateTime.ParseExact(datesText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            MatchCollection matches = Regex.Matches(datesText, @"\d\d\.\d\d\.\d\d\d\d");
            foreach (Match match in matches)
            {
                foreach (Capture capture in match.Captures)
                {
                    dates.Add(capture.Value);
                }
            }
            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine(DateTime.ParseExact(dates[i], //convert to DateTime format then to Canada display format
                    "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString(new CultureInfo("en-CA")));
            }           
        }
    }
}