using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncrArrMaxSequ
{
    class IncrArrMaxSequ
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
            int[] intArr1 = { 3, 2, 3, 4, 2, 2, 4 };
            //int length = intArr1.Length; //7
            //Console.WriteLine(length);
            int curLength = 0;
            int longest = 0;
            int maxSeqElem = 0;
            for (int i = 1; i < intArr1.Length; i++)
            {
                if ((intArr1[i] == intArr1[i - 1] + 1))
                {
                    curLength++;
                }
                if (curLength > longest)
                {
                    maxSeqElem = i; // here we are saving the last digit value from the array that has the highest value it terms of length
                    longest = curLength;
                }
                if ((intArr1[i] != intArr1[i - 1] + 1))   // here we are resetting the counters to 0 in order to record the future element, the last one that belongs to the longest sequence
                {
                    //Console.WriteLine();
                    //Console.WriteLine("Zero");
                    //Console.WriteLine();
                    curLength = 0;
                }
            }
            //Console.WriteLine(maxSeqElem);
            //Console.WriteLine(longest);
            Console.Write("{ ");
            for (int i = maxSeqElem - longest; i <= maxSeqElem; i++)
            {
                Console.Write("{0} ", (intArr1[i]) );
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}