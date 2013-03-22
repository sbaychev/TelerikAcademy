using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompTwoTxtFilsPrintNumSameAndDifLines
{
    class CompTwoTxtFilsPrintNumSameAndDifLines
    {
        static void Main(string[] args)
        {
        //Write a program that compares two text files line by line and prints the number 
       //of lines that are the same and the number of lines that are different. Assume the
       //files have equal number of lines.
            int n = 0, same = 0;

            using (StreamReader input1 = new StreamReader(@"text1.txt"))
            using (StreamReader input2 = new StreamReader(@"text2.txt"))
                for (string line1, line2; (line1 = input1.ReadLine()) != null && (line2 = input2.ReadLine()) != null; n++)
                    if (line1 == line2) same++;

            Console.WriteLine("{0} are the same, and {1} are not", same, n - same);
        }
    }
}