using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromesFromTxt
{
    class PalindromesFromTxt
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all palindromes, 
            //e.g. "ABBA", "lamal", "exe".
            string text = "ABBA, lamal, exe";
            string[] allText = text.Split(new char[] { ' ', ',', '!', '?', '.', ':', ';'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < allText.Length; i++)
            {
                if (getStatus(allText[i]))
                {
                    Console.WriteLine(allText[i]);
                }
            }
        }
        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}