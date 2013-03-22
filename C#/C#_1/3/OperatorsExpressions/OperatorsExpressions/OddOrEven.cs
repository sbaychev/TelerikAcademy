using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even.
            Console.Write("Do please put an integer number to check, if it is even or odd: ");
            string num = Console.ReadLine();
            int num1;
            if (int.TryParse(num, out num1))
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("\nThe number {0} you have entered is even", num1);
                }
                else
                {
                    Console.WriteLine("\nThe number {0} you have entered is odd", num1);
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