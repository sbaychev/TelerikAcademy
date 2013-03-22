using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CharToSymbol
{
    class CharToSymbol
    {
        static void Main(string[] args)
        {
            /*Declare a character variable and assign it with the symbol that has Unicode code 72. 
             * Hint: first use the Windows Calculator to find the hexadecimal representation of 72*/
            int intValue = 72;
            string hexValue = intValue.ToString("X");
            Console.WriteLine("The hexadecimal representation of 72 is {0}", hexValue);
            char symbol ='\u0048'; // where according to the calculator the number 72 in the base ten system converted to the hexadecimal is 48
            Console.WriteLine("\nThe symbol that has a Unicode code of 72 is: {0}", symbol);
            Console.ReadKey();
        }
    }
}