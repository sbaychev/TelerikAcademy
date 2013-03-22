using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            /*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the 
             * "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the 
             * rest, move it at the second position, etc.*/
            int[] theArr = { 23, 19, 35, 1 };     
            for (int i = 0; i < theArr.Length - 1; i++)
            {                                        
                int minNum = i; //up until the end length in terms of the loop's ittration of the array we are making sure that the sorting is going in an increasing order
                for (int j = i + 1; j < theArr.Length; j++)
                {
                    if (theArr[minNum] > theArr[j])//the overall idea is to compare each number with one another and make sure that
                    {                             //this particular one that we have taken at the moment is the smallest and if so
                        minNum = j;              //we are switching each other's place (with the one being compared to)
                    }
                    if (minNum != i)
                    {
                        int host = theArr[i];   
                        theArr[i] = theArr[minNum];
                        theArr[minNum] = host; 
                    }
                            //in the below provided construction we are making sure that any changes that have
                    //occured in the if(above it) are taken into account and recorded - e.g. if we have
                      //found an element that has a greater value than the currently taken as a [minNum]
                                             //-> then we switch their respective places - the smaller to the left, the larger to the right
                }
            }
            for (int i = 0; i < theArr.Length; i++)
            {
                Console.Write("{0} ", theArr[i]);
            }
            Console.WriteLine();
        }
    }
}