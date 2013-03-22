using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumReadPrintHexPercSci
{
    class NumReadPrintHexPercSci
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number and prints it as a decimal number, 
            //hexadecimal number, percentage and in scientific notation. Format the output
            //aligned right in 15 symbols.
            string number = Console.ReadLine();
            Console.WriteLine(String.Format("{0:D}".PadLeft(15), int.Parse(number)));
            Console.WriteLine(String.Format("{0:X}".PadLeft(15), int.Parse(number)));
            Console.WriteLine(String.Format("{0:p}".PadLeft(15), (float.Parse(number) / 100)));
            Console.WriteLine(String.Format("{0:E}".PadLeft(15), int.Parse(number)));
            Console.WriteLine();
        }
    }
}