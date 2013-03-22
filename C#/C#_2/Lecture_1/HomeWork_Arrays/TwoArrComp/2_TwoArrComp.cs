using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoArrComp
{
    class TwoArrComp
    {
        //Write a program that reads two arrays from the console and compares them element by element.
        static bool ArraysEqual<T>(T[] intArray1, T[] intArray2)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
           
            if (intArray1 == null || intArray2 == null)//altough we know they are not null, since we are hard coding them, this is for future use
            {
                return false;
            }
            if (intArray1.Length != intArray2.Length)
            {
                return false;
            }
            if (ReferenceEquals(intArray1, intArray2))
            {
                return true;
            }
            for (int i = 0; i < intArray1.Length; i++)
            {
                if (!comparer.Equals(intArray1[i], intArray2[i])) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] intArray1 = new int[5];// in order to make it easier, or so, we hardcode the two arrays to have a lenght of 5 and read
            //their values from the console, or we can define a resizabe List 
            int[] intArray2 = new int[5];// the size [5], here and above, option is as is just for examplary fuctions to do the task..
            string str = Console.ReadLine();//here we read the future arrays from the console
            string str1 = Console.ReadLine();
            intArray1 = str.Split(' ').Select(p => int.Parse(p)).ToArray();
            intArray2 = str1.Split(' ').Select(k => int.Parse(k)).ToArray();
            if (ArraysEqual(intArray1, intArray2))
            {
                Console.WriteLine("The Arrays are equal");
            }
            else
            {
                Console.WriteLine("The Arrays are Not equal");
            }
        }
    }
}