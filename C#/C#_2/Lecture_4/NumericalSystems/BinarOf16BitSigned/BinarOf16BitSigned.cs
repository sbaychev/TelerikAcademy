using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarOf16BitSigned
{
    class BinarOf16BitSigned
    {
        static void Main(string[] args)
        {
            //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
            Console.WriteLine(Convert.ToString(short.Parse(Console.ReadLine()), 2).PadLeft(16, '0'));
        }
    }
}