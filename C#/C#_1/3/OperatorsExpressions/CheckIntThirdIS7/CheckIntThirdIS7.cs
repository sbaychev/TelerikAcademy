using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIntThirdIS7
{
    class CheckIntThirdIS7
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true
            Console.Write("Please, do put in an integer: ");
            string consoleNum = Console.ReadLine();
            int number = Math.Abs(int.Parse(consoleNum));
            for (int i = 0; i < 2; i++) //making sure that it is done just twice, so that down below we can check if when 
            {                            //divided by 10, there is a 7 left   
                number /= 10;
            }
            if (number % 10 == 7)
            {
                Console.WriteLine("\nThe Third digit right-to-left is {0}", 7);
            }
            else
            {
                Console.Write("\nThe third digit right-to-left is NOT 7");
            }
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}