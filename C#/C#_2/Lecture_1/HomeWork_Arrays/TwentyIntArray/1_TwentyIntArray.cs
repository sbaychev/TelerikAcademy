using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyIntArray
{
    class TwentyIntArray
    {
        static void Main(string[] args)
        {
            //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
            //Print the obtained array on the console.
            int[] intArray = new int[20];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
                Console.Write(i+1);
                Console.Write(". ");
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
