using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSortStrings
{
    class QuickSortStrings
    {
        static void Main(string[] args)
        {
            //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
            string[] stringArray = new string[] //{ "z","e","x","c","m","q","a"}
	        {
	            "Egyptian",
	            "Indian",
	            "American",
	            "Chinese",
	            "Filipino",
	        };
            Quicksort(stringArray, 0, stringArray.Length - 1);
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}