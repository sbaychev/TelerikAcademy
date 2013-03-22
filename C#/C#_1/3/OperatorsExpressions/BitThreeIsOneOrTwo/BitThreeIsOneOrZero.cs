using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitThreeIsOneOrZero
{
    class BitThreeIsOneOrZero
    {
        static void Main(string[] args)
        {
            //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0
            Console.Write("Please, do put in an integer: ");
            string consNum = Console.ReadLine();
            uint num = uint.Parse(consNum);
            uint varCheckN = 8;
            if ((num & varCheckN) == varCheckN)
            {
                Console.WriteLine("\nThe 3 bit of the given Integer is 1");
            }
            else
            {
                Console.WriteLine("\nThe 3 bit of the given Integer is 0");
            }
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}