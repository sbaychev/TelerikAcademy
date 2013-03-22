using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitInEnglish
{
    class DigitInEnglish
    {
        static void Main(string[] args)
        {
            //Write program that asks for a digit and depending on the input shows the name of that digit (in English) 
            //using a switch statement.
            Console.Write("Enter a digit in the range [0..9]: ");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("\nZero\n");
                    break;
                case 1:
                    Console.WriteLine("\nOne\n");
                    break;
                case 2:
                    Console.WriteLine("\nTwo\n");
                    break;
                case 3:
                    Console.WriteLine("\nThree\n");
                    break;
                case 4:
                    Console.WriteLine("\nFour\n");
                    break;
                case 5:
                    Console.WriteLine("\nFive\n");
                    break;
                case 6:
                    Console.WriteLine("\nSix\n");
                    break;
                case 7:
                    Console.WriteLine("\nSeven\n");
                    break;
                case 8:
                    Console.WriteLine("\nEight\n");
                    break;
                case 9:
                    Console.WriteLine("\nNine\n");
                    break;
                default:
                    Console.WriteLine("\nNot a digit!\n");
                    break;
            }
        }
    }
}