using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevStrAndPrint
{
    class RevStrAndPrint
    {
        static void Main(string[] args)
        {
        //Write a program that reads a string, reverses it and prints the result at the 
       //console. Example: "sample"  "elpmas".
            string str = Console.ReadLine();
            string reverse = Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(reverse[i]); 
            }
            Console.WriteLine();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}