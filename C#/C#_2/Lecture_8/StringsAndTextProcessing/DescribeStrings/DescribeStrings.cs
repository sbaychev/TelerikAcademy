using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeStrings
{
    class DescribeStrings
    {
        static void Main(string[] args)
        {
            //Describe the strings in C#. What is typical for the string data type? 
            //Describe the most important methods of the String class.

            //Strings are sequences of characters
            //Each character is a Unicode symbol
            //Represented by the string data type in C# (System.String)
            //Strings are represented by System.String objects in .NET Framework
            //String objects contain an immutable (read-only) sequence of characters
            //Strings use Unicode to support multiple languages and alphabets
            //Strings are stored in the dynamic memory (managed heap)
            //System.String is reference type
            //String objects are like arrays of characters (char[])
            //Have fixed length (String.Length)
            //Elements can be accessed directly by index
            //The index is in the range [0...Length-1]

            //Length, this[], Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), 
            //Replace(oldStr, newStr), Remove(startIndex, length), ToLower(), ToUpper(), Trim()
            //Objects can be converted to strings and can be formatted in different styles (using ToString() method)
            //Strings can be constructed by using placeholders and formatting strings (String.Format(…))


        }
    }
}
