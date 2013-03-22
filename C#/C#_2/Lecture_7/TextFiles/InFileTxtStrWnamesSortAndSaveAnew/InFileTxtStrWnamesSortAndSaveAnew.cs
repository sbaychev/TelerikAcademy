using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InFileTxtStrWnamesSortAndSaveAnew
{
    class InFileTxtStrWnamesSortAndSaveAnew
    {
        static void Main(string[] args)
        {
        //Write a program that reads a text file containing a list of strings, sorts them 
        //and saves them to another text file.
        List<string> lines = ReadLines();
        lines.Sort();
        WriteLines(lines); 

        }
        static List<string> ReadLines()
        {
            List<string> lines = new List<string>();

            using (StreamReader input = new StreamReader(@"input.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    lines.Add(line);

            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter(@"output.txt"))
                foreach (string line in lines)
                    output.WriteLine(line);
        }
    }
}