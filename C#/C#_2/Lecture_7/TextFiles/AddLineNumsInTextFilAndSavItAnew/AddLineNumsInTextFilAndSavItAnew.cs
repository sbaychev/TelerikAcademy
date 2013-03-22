using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AddLineNumsInTextFilAndSavItAnew
{
    class AddLineNumsInTextFilAndSavItAnew
    {
        static void Main(string[] args)
        {
        //Write a program that reads a text file and inserts line numbers in front of each
        //of its lines. The result should be written to another text file.
            //var text = File.ReadAllText(@"file1.txt");
            //File.Create(@"fileNew.txt");
            //File.WriteAllText(@"fileNew.txt", text);
            //using (var output = File.Create(@"fileNew.txt"))
            //{
            //    string fileName = @"file1.txt";
            //    StreamWriter streamWriter = new StreamWriter(fileName);
            //    using (streamWriter)
            //    {
            //        for (int number = 1; number <= 20; number++)
            //        {
            //            streamWriter.WriteLine(number);
            //        }
            //    }
            //}
            int n = 1;
            using (StreamReader input = new StreamReader(@"file1.txt"))
            using (StreamWriter output = new StreamWriter(@"fileNew.txt"))
                for (string line; (line = input.ReadLine()) != null; n++)
                    output.WriteLine("{0}.{1}", n, line);
        }
    }
}