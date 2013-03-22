using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Program
    {
        //Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
        //It should hold error message and a range definition [start … end].Write a sample application that demonstrates the 
        //InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range 
        //[1..100] and dates in the range [1.1.1980 … 31.12.2013].

        static void Main(string[] args)
        {
            //dates in the range [1.1.1980 … 31.12.2013].
            try
            {
                DateTime date = ConsoleReadInteger(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                Console.WriteLine("Your date is: " + date.ToString("dd.MM.yyyy"));
            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine("{0}\nThe range must be: [{0}..{1}]", exception.Message, exception.StartRange, exception.EndRange);
            }
            //numbers in the range [1..100] 
            try
            {
                int number = ConcoleReadInteger(1, 100);
                Console.WriteLine("Your number is: " + number);
            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine("{0}\nThe range must be: [{0}..{1}]", exception.Message, exception.StartRange, exception.EndRange);
            }
        }
        //Reading from the Console Methods
        static DateTime ConsoleReadInteger(DateTime start, DateTime end)
        {
            DateTime date;
            do
            {
                Console.WriteLine("Put in a date (day/month/year)in the interval [{0}..{1}]", start.ToString("dd.MM.yyyy"), end.ToString("dd.MM.yyyy"));
            } while (!DateTime.TryParseExact(Console.ReadLine(), new string[] { "d/M/yyyy", "dd/MM/yyyy", "d/M/yy", "dd/MM/yy", "d.M.yyyy", "dd.MM.yyyy", "d.M.yy", "dd.MM.yy", }, CultureInfo.InvariantCulture, DateTimeStyles.None, out date));
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>(start, end, String.Format("Number is out of the asked for range [{0}..{1}]", start, end));
            }
            else
            {
                return date;
            }
        }
        static int ConcoleReadInteger(int start, int end)
        {
            int number;
            do
            {
                Console.WriteLine("Put in a number in the interval [{0}..{1}]", start, end);
            } while (!int.TryParse(Console.ReadLine(), out number));
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end, String.Format("Number is out of the asked for range[{0}..{1}]", start, end));
            }
            else
            {
                return number;
            }
        }
    }
}