using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
            Console.Write("n = "); //bits to swap are in n (varNumber)
            string number = Console.ReadLine();
            uint unsigInt = uint.Parse(number);
            int firstStartBit = 0; //the starting bit of the first set
            int secStartBit = 3; //the starting bit of the second set
            int numConsExchBits = 3; //the number of consecutive bits being swapped
            uint endSwapVal;    // bit-swapped result goes here

            uint x = (((unsigInt >> firstStartBit) ^ (unsigInt >> secStartBit)) & ((1U << numConsExchBits) - 1)); // XOR temporary
            //Console.WriteLine(x);
            endSwapVal = unsigInt ^ ((x << firstStartBit) | (x << secStartBit));
            Console.WriteLine("\nAfter the swap the new number has a Decimal Form of {0}\nand\na Binary Form of {1}\n",endSwapVal, Convert.ToString(endSwapVal,2).PadLeft(32, '0'));
        }
    }
}