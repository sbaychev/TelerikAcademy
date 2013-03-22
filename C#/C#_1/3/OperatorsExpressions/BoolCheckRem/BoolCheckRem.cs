using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoolCheckRem
{
    class BoolCheckRem
    {
        static void Main(string[] args)
        {
            //Write a boolean expression that checks for given integer if it can be divided (without remainder)
            //by 7 and 5 in the same time.
            Console.Write("Do please put an integer number to check, if it can be divided\n(without remainder) by 7 and 5 at the same time: ");
            string num = Console.ReadLine();
            int num1;
            if (int.TryParse(num, out num1))
            {
                if (num1 % 7 == 0 && num1 % 5 == 0)
                {
                    Console.WriteLine("\nThe number {0} you have entered is divisible by 7 and 5 at the same time", num1);
                }
                else
                {
                    Console.WriteLine("\nThe number {0} you have entered is Not divisible by 7 and 5 at the same time", num1);
                }
            }
            else
            {
                Console.WriteLine("\nYou Have Not Entered an Integer, Next Time Pleaso Do!");
            }

            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}