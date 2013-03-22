using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBin
{
    class HexToBin
    {
        static void Main(string[] args)
        {
           // Write a program to convert hexadecimal numbers to binary numbers (directly).
            //Console.WriteLine(int.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber));
            //Console.WriteLine(Convert.ToString(decNum, 2).PadLeft(8, '0'));
            string hexstring = Console.ReadLine();
            string binarystring = String.Join(String.Empty,hexstring.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            Console.WriteLine(binarystring);
        }

    }
}