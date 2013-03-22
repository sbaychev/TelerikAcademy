using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EntFileNamAndFulPatReadAndPrintConsAndAllExcpt
{
    class EntFileNamAndFulPatReadAndPrintConsAndAllExcpt
    {
        static void Main(string[] args)
        {
        //Write a program that enters file name along with its full file path 
        //(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
        //Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all 
        //possible exceptions and print user-friendly error messages.
            try
            {
                string filePath = Console.ReadLine();
                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine("{0}", line);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("The file path is incorrect or the file does not exist");
                Console.WriteLine();
            }
        }
    }
}