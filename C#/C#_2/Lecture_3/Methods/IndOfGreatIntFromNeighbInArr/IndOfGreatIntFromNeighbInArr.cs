using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndOfGreatIntFromNeighbInArr
{
    class IndOfGreatIntFromNeighbInArr
    {
        static void Main(string[] args)
        {
            //Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
            //Use the method from the previous exercise.
            int[] anArray = { 3, 1, 1, 4, 2, 3, 4, 6, 9, 4, 1, 2, 4, 9, 3 };
            //{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int ind = IsGreatThanNeighb(anArray);
            Console.WriteLine(ind);
        }
        static int IsGreatThanNeighb(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {

                if ( (arr[i - 1] < arr[i]) && (arr[i + 1] < arr[i]) )
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
