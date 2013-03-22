using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitInEnglish
{
    class LastDigitInEnglish
    {
        static void Main(string[] args)
        {
            //Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  
            //"four", 12309  "nine".
            string console = Console.ReadLine();
            string number = console.Substring(console.Length - 1);
            int last = int.Parse(number);
            LastDigAsWord(last);

        }
        static void LastDigAsWord(int lastDigit)
        {
            switch (lastDigit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}
