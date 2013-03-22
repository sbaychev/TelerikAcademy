using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvExchangeBits
{
    class AdvExchangeBits
    {
        static void Main(string[] args)
        {
            //* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, q+k-1} of given 32-bit unsigned integer.
            Console.Write("n = "); //bits to be swapped in the 32-bit unsigned integer n (varNumber)
            string number = Console.ReadLine();
            uint varNumber = uint.Parse(number);

            Console.Write("p = "); // position of the first bit of the sequence
            string pnumber = Console.ReadLine();
            int varPNumber = int.Parse(pnumber);

            Console.Write("q = "); // position of the exchanged first bit of the second sequence
            string qnumber = Console.ReadLine();
            int varQNumber = int.Parse(qnumber);

            Console.Write("k = "); // the number of consecutive bits to be swapped
            string knumber = Console.ReadLine();
            int varKNumber = int.Parse(knumber);
            uint endSwapV;    // bit-swapped result goes here

            uint x = (((varNumber >> varPNumber) ^ (varNumber >> varQNumber)) & ((1U << varKNumber) - 1)); // XOR temporary
            endSwapV = varNumber ^ ((x << varPNumber) | (x << varQNumber));
            Console.WriteLine("\nAfter the swap the new number is {0}", endSwapV);
        }
    }
}