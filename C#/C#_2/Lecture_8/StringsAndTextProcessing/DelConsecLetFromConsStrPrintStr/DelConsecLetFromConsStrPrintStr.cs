using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelConsecLetFromConsStrPrintStr
{
    class DelConsecLetFromConsStrPrintStr
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and replaces all series
            //of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
            string str = Console.ReadLine();//"aaaaabbbbbcdddeeeedssaa"; //yommmeeeemeetooo
            List<char> letters = new List<char>();
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1] || (i == 1 && str[i] != str[i - 1]) || 
                    (i == str.Length - 1 && (str[i] != str[i - 1] || str[i] != str[i + 1])))
                {
                    if ( i == 1) // the index 0 or 1 letter is different then the index 1 or 2,                        
                    {           //the general step str[i] == str[i - 1] is not going to catch it
                        if (str[i] != str[i - 1] && str[i] != str[i + 1])
                        {
                            letters.Add((str[i - 1]));
                            letters.Add((str[i]));
                            count = 1;
                        }
                        else if (str[i] != str[i + 1])
                        {
                            letters.Add((str[i]));
                            count = 1;
                        }
                        else if (str[i] != str[i - 1])
                        {
                            letters.Add((str[i - 1]));
                            count = 1;
                        }                  
                    }
                    else if (i == str.Length - 1 && str[i] != str[i - 1])// the last index letter is different then the index  last - 1, 
                    {                                                   //the general step str[i] == str[i - 1] is not going to catch it
                         letters.Add((str[i]));
                         count = 1;
                    }
                    else if (count == 1)
                    {
                        letters.Add((str[i - 1]));                       
                        count++;
                    }
                } 
                else if (i != str.Length - 1)
                {
                    if ( (str[i] != str[i - 1] && str[i] != str[i + 1] ))
                    {
                        letters.Add((str[i]));
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }           
                }
            }
            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write("{0}", letters[i]);
            }
            Console.WriteLine();
        }
    }
}