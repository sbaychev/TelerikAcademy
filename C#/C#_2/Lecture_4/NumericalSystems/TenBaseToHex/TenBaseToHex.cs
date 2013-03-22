using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenBaseToHex
{
    class TenBaseToHex
    {
        static void Main(string[] args)
        {
            //Write a program to convert decimal numbers to their hexadecimal representation.
            Console.WriteLine( (int.Parse(Console.ReadLine())).ToString("X") );
        }
    }
}