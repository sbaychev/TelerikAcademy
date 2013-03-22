using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplSubStrWotherInAtXtFile
{
    class ReplSubStrWotherInAtXtFile
    {
        static void Main(string[] args)
        {
        //Write a program that replaces all occurrences of the substring "start" with the substring
        //"finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

            //Modify the solution of the previous problem to replace only whole words 
            //(not substrings).
            using (StreamReader input = new StreamReader(@"input.txt"))
            using (StreamWriter output = new StreamWriter(@"output.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                      output.WriteLine(line.Replace("start", "finish"));          // Task 7
                    //output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Task 8
        }
    }
}
