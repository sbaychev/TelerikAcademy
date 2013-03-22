using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrOfStrSortMeth
{
    class ArrOfStrSortMeth
    {
        static void Main(string[] args)
        {
         // You are given an array of strings. Write a method that sorts the array by the length
        // of its elements (the number of characters composing them).

        int n = int.Parse(Console.ReadLine());       
        string[] arr = new string[n];
 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element [{0}]: ", i + 1);
                arr[i] = Console.ReadLine();
            }

        Console.WriteLine("Unsorted: {0}", String.Join(", ", arr));
        Console.WriteLine();
        Array.Sort(arr, new StringComparer());
        Console.WriteLine("Sorted by length:");
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }

    }
    
    class StringComparer : IComparer<string>
    {
        public int Compare(string element1, string element2)
        {
            var elementLenght1 = element1.Length;
            var elementLength2 = element2.Length;
            return elementLenght1.CompareTo(elementLength2);
        }
    }    
  }
}