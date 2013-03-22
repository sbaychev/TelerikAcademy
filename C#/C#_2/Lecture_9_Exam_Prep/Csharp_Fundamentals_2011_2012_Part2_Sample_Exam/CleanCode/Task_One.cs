using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class Task_One
    {
        static bool isQuoted = false;
        static bool isComment = false;
        static bool isLongComment = false;

        static void Main(string[] args)
        {
//Pesho always writes useless comments in his code to remind him about some non-important things.
//You are given N lines with valid C# code written by Pesho. Your task is to write a program that removes all 
//comments and all empty lines from the given code. Empty line is a line without C# code after removing the comments.

            int lengthLines = int.Parse(Console.ReadLine());
            string[] lines = new string[lengthLines];
            string[] editedLines = new string[lengthLines];

            for (int i = 0; i < lengthLines; i++)
            {
                lines[i] = Console.ReadLine();
            }
            for (int i = 0; i < lengthLines; i++)
            {
                editedLines[i] = RemoveComments(lines[i]);
                if (isLongComment == true)
                {
                    int start = i;
                    while (isLongComment == true)
                    {
                        editedLines[i] += RemoveComments(lines[start]);
                        start++;
                    }
                    i = start - 1;
                }
            }
            for (int i = 0; i < editedLines.Length; i++)
            {
                if (editedLines[i] != null && editedLines[i].Trim().Length != 0)
                {
                    Console.WriteLine(editedLines[i]);
                }
            }
        }

        private static string RemoveComments(string lines)
        {
            List<char> editedLine = new List<char>();
            int length = lines.Length;
            for (int i = 0; i < length; i++)
            {
                if (isQuoted == true)
                {                    
                    while (i < length && lines[i] != '"')
                    {

                        editedLine.Add(lines[i]);
                        if (lines[i] == '\\' && i + 1 < length && lines[i + 1] == '"')
                        {
                            editedLine.Add(lines[i + 1]);
                            i++;
                        }
                        i++;
                    }
                    if (i < length && lines[i] == '"')
                    {
                        editedLine.Add(lines[i]);
                        isQuoted = false;
                    }
                }
                else if (isLongComment == true)
                {
                    int index = lines.IndexOf("*/");
                    if (index == -1)
                    {
                        break;
                    }
                    else
                    {
                        i = index + 1;
                        isLongComment = false;
                    }
                }
                else if (lines[i] == '"')
                {
                    if (i - 1 > 0 && lines[i - 1] != '\\')
                    {
                        isQuoted = true;
                    }

                    editedLine.Add(lines[i]);
                }
                else if (lines[i] == '/')
                {
                    if (i + 1 < length && lines[i + 1] == '/')
                    {
                        if (i + 2 < length && lines[i + 2] == '/')
                        {
                            editedLine.Add(lines[i]);
                            editedLine.Add(lines[i]);
                            editedLine.Add(lines[i]);
                            i = i + 2;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (i + 1 < length && lines[i + 1] == '*')
                    {
                        isLongComment = true;
                    }
                    else
                    {
                        editedLine.Add(lines[i]);
                    }

                }
                else
                {
                    editedLine.Add(lines[i]);
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < editedLine.Count; i++)
            {
                result.Append(editedLine[i]);
            }

            return result.ToString();
            //int n = int.Parse(Console.ReadLine());

            //List<string> allText = new List<string>();
            //string line = "";
            //while (n > 0)
            //{
            //    line = Console.ReadLine();
            //    allText.Add(line);
            //    n--;
            //}
            //allText.RemoveAll(item => item.Length == 0);
            //var strings = @"@""";
            //var lineComments = "//";
            //var blockComment1 = "/*";
            //var blockComment2 = "*/";
            //for (int i = 0; i < allText.Count; i++)
            //{
            //    Match match = Regex.Match(allText[i], strings);
            //    Match match1 = Regex.Match(allText[i], lineComments);
            //    Match match2 = Regex.Match(allText[i], lineComments);

            //    if (match.Success)
            //    {                   
            //    }
            //    else if (match1.Success)
            //    {
            //        int index = allText[i].IndexOf(lineComments);
            //        string cleanPath = (index < 0)
            //            ? allText[i]
            //            : allText[i].Remove(index, allText[i].Length - index);
            //        allText[i] = cleanPath.TrimEnd();
            //    }
            //}

            //allText.RemoveAll(item => item.Length == 0);
            ////for (int i = 0; i < allText.Count; i++)
            ////{
            ////    Console.WriteLine(allText[i]);
            ////}
        }
    }