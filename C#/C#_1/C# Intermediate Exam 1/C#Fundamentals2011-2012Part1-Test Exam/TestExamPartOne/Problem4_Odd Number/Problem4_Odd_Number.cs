//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Problem4_Odd_Number
//{
//    class Problem4_Odd_Number
//    {
////You are given a list of N integer numbers all but one of which appears an even number of times.
////Write a program to find the one integer which appears an odd number of times.
////Input
////The input data is being read from the console.
////The number N is written on the first input line.
////On each of the following N lines there is one integer number written – the consequent number from the given list of numbers.
////The input data will always be valid and in the format described. There is no need to check it explicitly.
////Output
////The output data must be printed on the console.
////On the only output line you must print the integer from the list which appears an odd number of times.
////Constraints
////•	N will be positive odd integer number between 1 and 99 999, inclusive. 
////•	All of the numbers in the list will be integer numbers between -9 223 372 036 854 775 808
////and 9 223 372 036 854 775 807, inclusive.
////•	Always only one answer will exists and will be unambiguous.
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("{0:N}",long.MinValue);
//            //Console.WriteLine("{0:N}", long.MaxValue);
//            int N = int.Parse(Console.ReadLine());
//            long[] nNumbers = new long[N];
//            long oddNumber = 0;
//            for (int i = 0; i < N; i++)
//            {
//                nNumbers[i] = long.Parse(Console.ReadLine());
//            }
//            int count;
//            for (int i = 0; i < N; i++)
//            {
//                count = 0;
//                for (int j = 0; j < N; j++)
//                {
//                    if (nNumbers[i] == nNumbers[j])
//                    {
//                        count++;
//                    }
//                }
//                if (count % 2 != 0)
//                {
//                    oddNumber = nNumbers[i];
//                    break;
//                }
//            }
//            Console.WriteLine(oddNumber);
//        }
//    }
//}