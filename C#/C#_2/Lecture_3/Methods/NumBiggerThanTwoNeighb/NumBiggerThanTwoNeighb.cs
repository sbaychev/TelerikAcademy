using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumBiggerThanTwoNeighb
{
    class NumBiggerThanTwoNeighb
    {
        static void Main(string[] args)
        {
            //Write a method that checks if the element at given position in given array 
            //of integers is bigger than its two neighbors (when such exist).

            int index = int.Parse(Console.ReadLine());//12; //the index that we are looking at
            int n = int.Parse(Console.ReadLine());// the length of the array
            int[] intArr = new int[index];//{ 1, 12, 3, 4, 5, 6, 1, 8, 3, 4, 1, 6, 2, 3, 5, 44, 13, 56, 12, 3 };
            for (int i = 0; i < n; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }
            NumbInArrGreaterTwoNeigb(index, intArr);
        }
        static void NumbInArrGreaterTwoNeigb(int ind, int [] arr)
        {
            if (ind > arr.Length - 1)
            {
                Console.WriteLine("there is no number at index {0} in the array", ind);
                return;
            }
            else if (ind == arr.Length - 1 && ind == 0)
            {
                Console.WriteLine("{0} is by itself in the array", arr[ind]);
                return;
            }
            else if (ind == arr.Length - 1 && ind + 1 > arr.Length - 1)
            {
                if (arr[ind] > arr[ind - 1])
	            {
		            Console.WriteLine("{0} is bigger than its left neighbour {1}, as the first number is last in the array",
                        arr[ind], arr[ind - 1]);
                    return;
	            }
                else
	            {
                    Console.WriteLine("{0} is not bigger than its left neighbour {1}, as the first number is last in the array",
                        arr[ind], arr[ind - 1]);
                    return;
	            }
            }
            else if (ind == 0 && arr.Length > 1)
            {
                if (arr[ind] > arr[ind + 1])
                {
                    Console.WriteLine("{0} is bigger than its right neighbour {1}, as the first number is the first one in the array",
                        arr[ind], arr[ind + 1]);
                    return;
                }
                else
                {
                    Console.WriteLine("{0} is not bigger than its right neighbour {1}, as the first number is the first one in the array",
                     arr[ind], arr[ind + 1]);
                    return;
                }
            }
            else
	        {
                int greater = (arr[ind] > arr[ind - 1] ? arr[ind] : arr[ind - 1]) > arr[ind + 1] ?
                    (arr[ind] > arr[ind - 1] ? arr[ind] : arr[ind - 1]) : arr[ind + 1];
                if (arr[ind] == greater)
                {
                    Console.WriteLine("{0} at index {1} is the greatest of its two neighbours {2} and {3}",
                        arr[ind], ind, arr[ind - 1], arr[ind + 1]);
                    return;
                }
                else
                {
                    Console.WriteLine("{0} at index {1} is not the greatest of its two neighbours {2} and {3}",
                       arr[ind], ind, arr[ind - 1], arr[ind + 1]);
                    return;
                }
	        }
        }
    }
}