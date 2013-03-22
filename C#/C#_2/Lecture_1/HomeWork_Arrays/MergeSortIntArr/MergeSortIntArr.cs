using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSortIntArr
{
    /*Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).*/
     
    public static class MergeSorter
    {
        public static List<T> Sort<T>(List<T> list) where T : IComparable
        {
            if (list.Count <= 1)
            {
                return list;
            }

            List<T> left = list.GetRange(0, list.Count / 2);
            List<T> right = list.GetRange(left.Count, list.Count - left.Count);
            return Merge(Sort(left), Sort(right)); //the divide and conquer part
        }

        public static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable
        {
            List<T> result = new List<T>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) <= 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            result.AddRange(left);
            result.AddRange(right);
            return result;
        }
        static void Main(string[] args)
        {            
            List<int> testList = new List<int> { 1, 5, 2, 7, 3, 9, 4, 6 };
            printList(testList);
            printList(MergeSorter.Sort(testList));
        }
        private static void printList<T>(List<T> list)
        {
            foreach (var t in list)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }
    }
}