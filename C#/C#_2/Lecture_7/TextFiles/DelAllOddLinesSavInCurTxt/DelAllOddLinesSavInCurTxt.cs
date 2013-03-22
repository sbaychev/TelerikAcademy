﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DelAllOddLinesSavInCurTxt
{
    class DelAllOddLinesSavInCurTxt
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from given text file all odd lines.
            //The result should be in the same file.
            WriteLines(ReadEvenLines());
        }
        static List<string> ReadEvenLines()
        {
            List<string> lines = new List<string>();

            int n = 1;

            using (StreamReader input = new StreamReader(@"input.txt"))
                for (string line; (line = input.ReadLine()) != null; n++)
                    if (n % 2 == 0) lines.Add(line);

            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter(@"input.txt"))
                foreach (string line in lines)
                    output.WriteLine(line);
        }
    }
}