using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NarrKelemNhaveSumS
{
    class NarrKelemNhaveSumS
    {
        static void Main(string[] args)
        {
            //* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
            //Find in the array a subset of K elements that have sum S or indicate about its absence.
            
            int n = 5;//int.Parse(Console.ReadLine()); // the number of members in the array
            int k = 2;//int.Parse(Console.ReadLine());
            int sum = 3;//int.Parse(Console.ReadLine()); //
            List<int> intArr = new List<int>();
            List<int> finalArr = new List<int>();
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                intArr.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 1; i <= (int)Math.Pow(2, n) - 1; i++)
            {
                List<int> tempArr = new List<int>();

                for (int j = 1; j <= n; j++)
                {
                    if (((i >> (j - 1)) & 1) == 1)// the idea is to get all possible sub arrays of the given
                    {
                        tempArr.Add(intArr[j - 1]);
                    }
                }
                if ( (tempArr.Sum() == sum) && (tempArr.Count == k) )
                {
                    finalArr = tempArr;
                    found = true;
                    //break;
                }
                if (i == (int)Math.Pow(2, n) - 1 && found == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("A subset of {0} elements that have sum {1} has not been found",k ,sum );
                }
            }
            if (found)
            {
                Console.WriteLine();
                Console.Write("found a subset of {0} elements {{ ", k);
                for (int i = 0; i < finalArr.Count; i++)
                {
                    if (i == finalArr.Count - 1)
                    {
                        Console.Write("{0}", finalArr[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", finalArr[i]);
                    }
                }
                Console.Write(" }} that have sum = {0}", sum);
                Console.WriteLine();
            }           
        }
    }
}
