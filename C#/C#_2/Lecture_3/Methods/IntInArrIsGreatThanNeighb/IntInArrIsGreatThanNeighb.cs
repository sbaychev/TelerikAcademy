using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntInArrIsGreatThanNeighb
{
    class IntInArrIsGreatThanNeighb
    {
        static void Main(string[] args)
        {
            //Write a method that checks if the element at given position in given array of integers is 
            //bigger than its two neighbors (when such exist).
            int index;
            do //here we input the desired position that we want to check in the array up until we get an index > 0 value
            {
                index = int.Parse(Console.ReadLine());

            } while (index <= 0);
            int [] anArray = { 3, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            IsGreatThanNeighb(index, anArray);
        }
        static void IsGreatThanNeighb(int ind, int[] arr)
        {
            if ((arr[ind - 1] < arr[ind]) && (arr[ind + 1] < arr[ind]))
            {
                Console.WriteLine("{0} at position {1} is bigger than its two neighbours {2} and {3}", arr[ind], ind, arr[ind - 1], arr[ind + 1]);
            }
            else
            {
                Console.WriteLine("{0} at position {1} is NOT bigger than its two neighbours {2} and {3}", arr[ind], ind, arr[ind - 1], arr[ind + 1]);
            }
        }
    }
}
