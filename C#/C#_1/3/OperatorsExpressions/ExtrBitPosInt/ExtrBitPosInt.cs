using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtrBitPosInt
{
    class ExtrBitPosInt
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from a given integer i the value of a given bit number b. 
            //Example: i=5; b=2  value=1
            Console.Write("i = ");
            string consNumI = Console.ReadLine();
            int numI = int.Parse(consNumI);
            Console.Write("b = ");
            string consNumB = Console.ReadLine();
            int numB = int.Parse(consNumB);
            int mask = 1 << numB;
            Console.WriteLine(mask);
            int varNumAndMask = numI & mask;
            Console.WriteLine(varNumAndMask);
            int bit = varNumAndMask >> numB;
            Console.WriteLine("->value = {0}", bit);
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}