using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForbWordsInTextReplWiStars
{
    class ForbWordsInTextReplWiStars
    {
        static void Main(string[] args)
        {
        //We are given a string containing a list of forbidden words and a text containing
        //some of these words. Write a program that replaces the forbidden words with asterisks.Example:
        //Microsoft announced its next generation PHP compiler today. 
        //It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
        //Words: "PHP, CLR, Microsoft"
        //The expected result:
        //********* announced its next generation *** compiler today. 
        //It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
            string text = "Microsoft announced its next generation PHP compiler today."+
                "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string wordOne = "Microsoft";
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < wordOne.Length; i++)
                b.Append("*");
            string starsOne = b.ToString();
            b.Clear();
            string wordTwo = "PHP";
            for (int i = 0; i < wordTwo.Length; i++)
                b.Append("*");
            string starsTwo = b.ToString();
            b.Clear();
            string wordThree = "CLR";
            for (int i = 0; i < wordThree.Length; i++)
                b.Append("*");
            string starsThree = b.ToString();
            b.Clear();
            StringBuilder sb = new StringBuilder(text);
            sb.Replace(wordOne, starsOne);
            sb.Replace(wordTwo, starsTwo);
            sb.Replace(wordThree, starsThree);
            Console.WriteLine(sb.ToString());
            //text.IndexOf(wordOne);
        }
    }
}