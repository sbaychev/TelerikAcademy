using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSequeOfEquElem
{
    class MaxSequeOfEquElem
    {
        static void Main(string[] args)
        {
            // Write a program that finds the maximal sequence of equal elements in an array.
            //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.

            int[] intArr = { 2, 1, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1, 1, 3, 4 };
            //int length = intArr.Length;
            //Console.WriteLine(length);
            int curLength = 0;
            int longest = 0;
            int maxSeqElem = 0;
            for (int i = 1; i < intArr.Length; i++)
            {
                if ((intArr[i] != intArr[i - 1]))   // here we are resetting the counters to 0 in order to record the future element with the longest sequence
                {
                    //Console.WriteLine();
                    //Console.WriteLine("Zero");
                    //Console.WriteLine();
                    curLength = 1;//one because there is always
                }
                //Console.WriteLine(intArr[i]);
                //Console.WriteLine("Itteration {0}", i);
                if ((intArr[i] == intArr[i - 1])) // the above for cycle starts at position 1, because we are going to move a
                {                                //  position ahead in order to compare it with the previous digit, e.g. i - 1                  
                    curLength ++;
                }
                if (curLength > longest)
                {
                    maxSeqElem = intArr[i]; // here we are saving the last digit value from the array that has the highest value it terms of length
                    longest = curLength;
                }
            }
            Console.Write("{ ");
            for (int i = 0; i < longest; i++)
            {
                Console.Write("{0} ", maxSeqElem);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}