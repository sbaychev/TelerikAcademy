using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to their decimal representation.
            Console.WriteLine( int.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber) );          
        }
    }
}