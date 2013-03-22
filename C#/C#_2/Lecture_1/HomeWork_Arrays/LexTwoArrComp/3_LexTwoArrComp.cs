using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LexTwoArrComp
{
    class LexTwoArrComp
    {
        static void Main(string[] args)
        {
            //Write a program that compares two char arrays lexicographically (letter by letter).
            char [] arr1 = {'a','v','f','d','t','q','a'};
            char[] arr2 =  {'a','v','f','d','t','q','b'};
            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine("The array arr2 is lexicographically earlier than the array arr1");
            }
            else if (arr2.Length > arr1.Length)
            {
                Console.WriteLine("The array arr1 is lexicographically earlier than the array arr2");
            }
            else if (arr1.Length == arr2.Length)
            {
                string str1 = new string(arr1);
                string str2 = new string(arr2);
                //Console.WriteLine(str1);
                //Console.WriteLine(str2);
                if (string.CompareOrdinal(str1, str2) == 0)
                {
                    Console.WriteLine("The arrays arr1 and arr2 are the same");
                }
                if (string.CompareOrdinal(str1, str2) == 1)
                {
                    Console.WriteLine("The array arr1 is after the array arr2");
                }
                if (string.CompareOrdinal(str1, str2) == -1)
                {
                    Console.WriteLine("The array arr1 comes before the array arr2");
                }
            }
            
        }
    }
}