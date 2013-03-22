using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalSystems
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            //Write a program to convert decimal numbers to their binary representation.
            //int decNum = 1;
            int decNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(decNum, 2).PadLeft(32, '0'));
        }
    }
}