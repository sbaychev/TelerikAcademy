using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadCharStrOfTwentyIfAnyEptFilStars
{
    class ReadCharStrOfTwentyIfAnyEptFilStars
    {
        static void Main(string[] args)
        {
        //Write a program that reads from the console a string of maximum 20 characters. 
        //If the length of the string is less than 20, the rest of the characters should 
        //be filled with '*'. Print the result string into the console.
            StringBuilder sb = new StringBuilder();
            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // won't show up in console
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            loop = false;
                            break;
                        }
                    default:
                        {
                            if (sb.Length < 20)
                            {
                                sb.Append(keyInfo.KeyChar);
                                Console.Write(keyInfo.KeyChar);
                            }
                            break;
                        }
                }
            }
            string str = sb.ToString();
            if (str.Length < 20)
            {
                int count = str.Length;
                do
                {                  
                    sb.Append("*");
                    count++;
                } while (count < 20);
            }
            str = sb.ToString();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0} ", i + 1);
            }
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (i <= 9)
                {
                    Console.Write("{0} ", str[i]);
                }
                else if (i == 10)
                {
                    Console.Write(" {0}  ", str[i]);
                }
                else
                {
                    Console.Write("{0}  ", str[i]);
                }                
            }
            Console.WriteLine();
        }
    }
}