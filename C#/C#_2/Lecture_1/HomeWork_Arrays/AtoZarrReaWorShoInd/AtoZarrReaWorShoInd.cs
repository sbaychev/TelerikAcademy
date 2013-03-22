using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtoZarrReaWorShoInd
{
    class AtoZarrReaWorShoInd
    {
        static void Main(string[] args)
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z). 
            //Read a word from the console and print the index of each of its letters in the array.
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 
                                  'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            string word = Console.ReadLine();
            char[] alphaWord = word.ToCharArray();
            Console.WriteLine();
            for (int i = 0; i < alphaWord.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (char.ToLower(alphaWord[i]) == char.ToLower(alphabet[j]))
                    {
                        Console.WriteLine("{0} {1} ", alphaWord[i], j);
                    }
                }
            }

        }
    }
}