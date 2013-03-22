using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerINHex
{
    class IntegerINHex
    {
        /*Declare an integer variable and assign it with the value 254 in hexadecimal format. 
            * Use Windows Calculator to find its hexadecimal representation*/
        static void Main(string[] args)
        {
            int intValue = 254;
            string hexValue = intValue.ToString("X");
            Console.WriteLine("The Integer variable intValue {0} in Hexadecimal format is {1}", intValue, hexValue);
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}