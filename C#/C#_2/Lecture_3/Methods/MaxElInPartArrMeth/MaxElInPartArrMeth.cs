using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElInPartArrMeth
{
    class MaxElInPartArrMeth
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index.
        //Using it write another method that sorts an array in ascending / descending order.

        static void maxElem(int index, int[] array)
        {
        int i = index;
        for (int j = i + 1; j < array.Length; j++)
            {
                if (array [j] < array [index])
                {
                    index = j;
                }
            }
            if (index != i)
            {
                swapElem(i, index, array); 
            }
        }
    
    static void minElem(int index, int[] array)
    {
        int i = index;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[index])
            {
                index = j;
            }
        }
        if (index != i)
        {
            swapElem(i, index, array);
        }
    }

    static void swapElem(int ind1, int ind2, int[] arr)
    { 
        int temp = arr[ind1];
        arr[ind1] = arr[ind2];
        arr [ind2] = temp;
    }

    static void Main()
    {
        string inputVar;
        uint n;
        do
        {
            Console.Write("Enter array length: ");
        }
        while (!(uint.TryParse(inputVar = Console.ReadLine(), out n)) || n == 0);

        do
        {
            Console.Write("Pick a sort: a-ascending; d-descending: ");
            inputVar = Console.ReadLine();
        }
        while (!(inputVar == "a" || inputVar == "d"));

        int[] arrayOfints = new int[n];

        Console.WriteLine("Now enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arrayOfints[i] = int.Parse(Console.ReadLine());
        }

        int minIndex = 0;
        for (int i = 0; i < n - 1; i++)
        {
            minIndex = i;
            if (inputVar == "a")
            {
                maxElem(minIndex, arrayOfints);
            }
            else if (inputVar == "d")
            {
                minElem(minIndex, arrayOfints);
            }
        }
        switch (inputVar)
        {
            case "a":
                Console.WriteLine("The array after selection sort ascending:");
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0} ", arrayOfints[k]);
                }
                break;
            case "d":
                Console.WriteLine("The array after selection sort descending:");
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0} ", arrayOfints[k]);
                }
                break;
        }
        Console.WriteLine();
    }
    }
}