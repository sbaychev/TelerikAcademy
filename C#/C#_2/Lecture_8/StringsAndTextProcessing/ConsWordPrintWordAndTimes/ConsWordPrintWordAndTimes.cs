using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsWordPrintWordAndTimes
{
    class ConsWordPrintWordAndTimes
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and lists all different
            //words in the string along with information how many times each word is found.
            string str = Console.ReadLine();
            List<string> distWords = new List<string>();
            string[] words = str.ToLower().Split(' ');
            var dWords = words.Distinct();

                foreach (var item in dWords)
                {
                   distWords.Add(item);
                }
                int[] times = new int[distWords.Count];
                for (int i = 0; i < distWords.Count; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (distWords[i] == words[j])
                        {
                            times[i]++;
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < distWords.Count; i++)
                {
                    if (times[i] >= 1)
                    {
                        Console.Write("{0} {1} times", distWords[i], times[i]);
                        Console.WriteLine();
                    }
                }
        }
    }
}