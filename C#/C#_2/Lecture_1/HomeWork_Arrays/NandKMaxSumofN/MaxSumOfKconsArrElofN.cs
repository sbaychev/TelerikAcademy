using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSumOfKconsArrElofN
{
    public class MaxSumOfKconsArrElofN
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете от конзолата две цели числа N и K (K<N), и масив от N елемента. 
            //Да се намерят тези K поредни елемента, които имат максимална сума.
            //Write a program that reads two integer numbers N and K and an array of N elements from the console. 
            //Find in the array those K elements that have maximal sum.
            int nNum = int.Parse(Console.ReadLine());
            //int nNum = 6;
            //int kNum = 2;
            int kNum = int.Parse(Console.ReadLine());
            int[] nArr = new int [nNum];
            for (int i = 0; i < nNum; i++) //initialization of the nArr array, one after another N elemnts are recorded
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }
            Q_sort(0, nArr.Length - 1, nArr);
            //for (int i = 0; i < nArr.Length; i++)
            //{
            //    Console.Write(" {0}", nArr[i]);
            //}
            Console.Write("{ ");
            int check = 1;
            do
            {
                Console.Write("{0} ", nArr[nArr.Length - 1 - kNum + check]);
                check++;

            } while (check <= kNum);
            Console.Write("}");
            Console.WriteLine();
        }
        public static void Q_sort(int left, int right, int[] array)
        {
            int pivot, l_hold, r_hold;

            l_hold = left;
            r_hold = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[left] = pivot;
            pivot = left;
            left = l_hold;
            right = r_hold;

            if (left < pivot)
            {
                Q_sort(left, pivot - 1, array);
            }

            if (right > pivot)
            {
                Q_sort(pivot + 1, right, array);
            }
        }
    }
}