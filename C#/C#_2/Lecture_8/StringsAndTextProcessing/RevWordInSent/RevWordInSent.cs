using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevWordInSent
{
    class RevWordInSent
    {
        static void Main(string[] args)
        {
            //Write a program that reverses the words in given sentence.
            //Example: "C# is not C++, not PHP and not Delphi!" 
            // "Delphi not and PHP, not C++ not is C#!".
            string str = "C# is not C++, not PHP and not Delphi!";
            char [] charStr = str.ToCharArray();
            ReverseWords(charStr);
            Console.WriteLine();      
        }  
        public static void ReverseWords(char[] words)
        {
            //O(n)
            int lenght = words.Length - 1;
            char temp = 'o';
            //Console.WriteLine(lenght);
            //O(n/2)
            for (int i = 0; i <= lenght/2; i++)
            {
                //Console.WriteLine(i);
                //if (words[i] == ',' || words[i] == '.' || words[i] == '!' || words[i] == '?')
                //{
                //    i--;
                //}
                //else
                //{
                    //swap char at n-i with i
                    temp = words[i];
                    words[i] = words[lenght - i];
                    words[lenght - i] = temp;
                //}       
            }

            int wordStartIndex = 0;
            int wordEndIndex = 0;
            for (int i = 0; i <= lenght; i++)
            {
                if (words[i] == ' ' || i == lenght || words[i] == ',')
                {
                    //special care for last word
                    if (i != lenght)
                    {
                        wordEndIndex = i - 1;
                    }
                    //if (words[i] == '.' || words[i] == '!' || words[i] == '?')
                    //{
                    //    //Console.WriteLine("2a2");
                    //    wordEndIndex = lenght;
                    //}
                    else
                    {
                        //Console.WriteLine("1a1");
                        wordEndIndex = lenght;
                    }
                        
                    for (int j = wordStartIndex; j <= (wordStartIndex + wordEndIndex) / 2; j++)
                    {
                        //swap char at n-i with i

                        temp = words[j];
                        words[j] = words[wordEndIndex + wordStartIndex - j];
                        words[wordEndIndex + wordStartIndex - j] = temp;
                    }
                    wordStartIndex = i + 1;
                }
            }

            //print the reversed words in given string
            for (int i = 0; i <= lenght; i++)
            {
                Console.Write(words[i]);
            }
            Console.WriteLine();
        }
    }
}