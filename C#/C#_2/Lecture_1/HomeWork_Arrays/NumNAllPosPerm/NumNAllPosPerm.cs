using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumNAllPosPerm
{
    class NumNAllPosPerm
    {
        static void Main(string[] args)
        {
            //* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
            //  Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

            int n = int.Parse(Console.ReadLine());
            int k = 1;
            NumNAllPosPerm pg = new NumNAllPosPerm(n, k);
            while (pg.hasMore())
            {
                int[] temp = pg.getNext();
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private int[] array;
        private int firstNum;
        private bool firstReady = false;
 
        public NumNAllPosPerm(int n, int firstNum_)
        {
            //if (n < 1)
            //{
            //    throw new ArgumentException("The n must be min. 1");
            //}
            firstNum = firstNum_;
            array = new int[n];
            reset();
        }

        public void reset() // sets up the array
        {
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = i + firstNum;
            }
            firstReady = false;
        }
 
        public bool hasMore() 
        {
            bool end = firstReady;
            for (int i = 1; i < array.Length; i++) 
            {
                end = end && array[i] < array[i-1];
            }
            return !end;
        }

        public int[] getNext()
        {
            if (!firstReady)
            {
                firstReady = true;
                return array;
            }

            int temp;
            int j = array.Length - 2;
            int k = array.Length - 1;

            // Find largest index j with a[j] < a[j+1]

            for (; array[j] > array[j + 1]; j--) ;

            // Find index k such that a[k] is smallest integer
            // greater than a[j] to the right of a[j]

            for (; array[j] > array[k]; k--) ;

            // Interchange a[j] and a[k]

            temp = array[k];
            array[k] = array[j];
            array[j] = temp;

            // Put tail end of permutation after jth position in increasing order

            int r = array.Length - 1;
            int s = j + 1;

            while (r > s)
            {
                temp = array[s];
                array[s++] = array[r];
                array[r--] = temp;
            }
            return array;
        }
    }
}