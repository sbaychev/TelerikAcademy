using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConcatTwoTextFileIntOne
{
    class ConcatTwoTextFileIntOne
    {
        static void Main(string[] args)
        {
        //Write a program that concatenates two text files into another text file.
            using (var output = File.Create("file1Name.txt"))
            {
                foreach (var file in new[] { "file1.txt", "name.txt" })
                {
                    using (var input = File.OpenRead(file))
                    {
                        input.CopyTo(output);
                    }
                }
            }
            //const int chunkSize =  1024; // 1KB
            //var inputFiles = new[] { "file1.txt", "name.txt"};
            //using (var output = File.Create("fileName.txt"))
            //{
            //    foreach (var file in inputFiles)
            //    {
            //        using (var input = File.OpenRead(file))
            //        {
            //            var buffer = new byte[chunkSize];
            //            int bytesRead;
            //            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            //            {
            //                output.Write(buffer, 0, bytesRead);
            //            }
            //        }
            //    }
            //}
        }
    }
}
