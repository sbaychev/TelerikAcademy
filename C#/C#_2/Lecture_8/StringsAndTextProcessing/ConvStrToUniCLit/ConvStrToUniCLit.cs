using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConvStrToUniCLit
{
    class ConvStrToUniCLit
    {
        static void Main(string[] args)
        {
            //Write a program that converts a string to a sequence of C# Unicode character
            //literals. Use format strings. Sample input: Hi! Expected output: \u0048\u0069\u0021
            //string input = "Hi";
            //Console.WriteLine(Microsoft.JScript.GlobalObject.escape(input));

            string str = Console.ReadLine();//"Hi!";
            byte[] unibyte = Encoding.UTF8.GetBytes(str);
            string uniString = string.Empty;
            foreach (byte b in unibyte)
            {
                uniString += string.Format("{0}{1}", @"\u00", b.ToString("X"));

            }
            Console.WriteLine(uniString);
        }
    }
}