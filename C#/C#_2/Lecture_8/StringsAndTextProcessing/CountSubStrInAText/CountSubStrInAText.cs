using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountSubStrInAText
{
    class CountSubStrInAText
    {
        static void Main(string[] args)
        {
        //Write a program that finds how many times a substring is contained in a given 
        //text (perform case insensitive search).
            string text = Console.ReadLine().ToLower();//"once upon and once upon the once of once".ToLower();
            string subString = "on".ToLower();
            int count = text.Length - text.Replace(subString, "").Length;
            Console.WriteLine(count/subString.Length);//dividing it because it counts/ replaces it character by character
        }
    }
}