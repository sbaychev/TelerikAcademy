using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiveProperValues
{
    class FiveProperValues
    {
        static void Main(string[] args)
        {
            /*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int,
             * uint, long, ulong to represent the following values: 52130, -115, 4 825 932, 97, -10 000.
            */
            sbyte @sbyte = -115;
            ushort @ushort = 10000;
            byte @byte = 97;
            ushort @ushort1 = 52130;
            uint @uint = 4825932;

            Console.WriteLine("number1 is {0} \nnumber2 is {1} \nnumber3 is {2} \nnumber4 is {3} \nand \nnumber5 is {4}", 
                @sbyte, @ushort, @byte, @ushort1, @uint);            
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
