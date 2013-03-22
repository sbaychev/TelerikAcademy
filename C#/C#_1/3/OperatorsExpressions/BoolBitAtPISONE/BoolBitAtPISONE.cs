using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoolBitAtPISONE
{
    class BoolBitAtPISONE
    {
        static void Main(string[] args)
        {
            // Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has
            //value of 1. Example: v=5; p=1 -- > false.
            Console.Write("Please, do put in an integer: ");
            string consInt = Console.ReadLine();
            int vInt = int.Parse(consInt);
            Console.Write("Please, do put in the desired bit's position p, to check if it equals one: ");
            string consPos = Console.ReadLine();
            int position = int.Parse(consPos);
            int mask = 1 << position;
            //Console.WriteLine(mask);
            int varNumAndMask = vInt & mask;
            int bit = varNumAndMask >> position;
          
            if (bit == 1)
            {
                Console.WriteLine("\n{0}",(bit == 1));
            }
            else
            {
                Console.WriteLine("\n{0}",(bit == 1));
            }
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}