using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfElGreatThanNeighb
{
    class IndexOfElGreatThanNeighb
    {
        static void Main(string[] args)
        {
            //Write a method that returns the index of the first element in array that is bigger 
            //than its neighbors, or -1, if there’s no such element.Use the method from the previous exercise.

            //int index = int.Parse(Console.ReadLine());//12; //the index that we are looking at
            //int n = int.Parse(Console.ReadLine());// the length of the array
            int[] intArr = { 0, 1, 0 };//{ 1, 0, 2 };//{ 1, 12, 3, 4, 5, 6, 1, 8, 3, 4, 1, 6, 2, 3, 5, 44, 13, 56, 12, 3 };
            //for (int i = 0; i < n; i++)
            //{
            //    intArr[i] = int.Parse(Console.ReadLine());
            //}
            IndexOfElGreaterThanNeighb(intArr);
        }
        static void IndexOfElGreaterThanNeighb(int[] arr)
        {
            if (1 == arr.Length)
            {
                Console.WriteLine("{0} is by itself in the array", arr[arr.Length - 1]);
                return;
            }
            for (int i = 1; i < arr.Length; i++)
			{
                if (arr.Length > 2)
                {
                    int greater = (arr[i] > arr[i - 1] ? arr[i] : arr[i - 1]) > arr[i + 1] ?
                        (arr[i] > arr[i - 1] ? arr[i] : arr[i - 1]) : arr[i + 1];
                    if (arr[i] == greater)
                    {
                        Console.WriteLine("{0} at index {1} is the greatest of its two neighbours {2} and {3}",
                            arr[i], i, arr[i - 1], arr[i + 1]);
                        return;
                    }
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine(-1);
                    return;
                }
             }

            }
        }
    }