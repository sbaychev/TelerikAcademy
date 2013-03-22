using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictWordTransString
{
    class DictWordTransString
    {
        static void Main(string[] args)
        {
            //A dictionary is stored as a sequence of text lines containing words and 
            //their explanations. Write a program that enters a word and translates it by 
            //using the dictionary. Sample dictionary:
            //.NET – platform for applications from Microsoft
            //CLR – managed execution environment for .NET
            //namespace – hierarchical organization of classes
            string[] dictMeaning = { 
                  ".NET – platform for applications from Microsoft",
                  "CLR – managed execution environment for .NET",
                  "namespace – hierarchical organization of classes" };
            string word = Console.ReadLine();//".NET";
            int dictPlace = -1;
            for (int i = 0; i < dictMeaning.Length; i++)
            {
                if (dictMeaning[i].ToLower().StartsWith(word.ToLower()))
                {
                    dictPlace = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(dictMeaning[dictPlace]);
        }
    }
}