﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

namespace RemInFileAllWordsListOthFile
{
    class RemInFileAllWordsListOthFile
    {
        static void Main(string[] args)
        {
            //Write a program that removes from a text file all words listed in given
            //another text file. Handle all possible exceptions in your methods.
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines(@"words.txt")) + @")\b";

                using (StreamReader input = new StreamReader(@"input.txt"))
                using (StreamWriter output = new StreamWriter(@"output.txt"))
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}