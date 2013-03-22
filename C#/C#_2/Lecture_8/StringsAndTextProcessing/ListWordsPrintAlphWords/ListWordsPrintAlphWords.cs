using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListWordsPrintAlphWords
{
    class ListWordsPrintAlphWords
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words, separated by spaces and prints 
            //the list in an alphabetical order.
            string listWords = Console.ReadLine();
            string[] splStr = listWords.Split(' ');
            var sort = from s in splStr
                       orderby s
                       select s;

            foreach (string c in sort)
            {
                Console.WriteLine(c);
            }
        }
    }
}
