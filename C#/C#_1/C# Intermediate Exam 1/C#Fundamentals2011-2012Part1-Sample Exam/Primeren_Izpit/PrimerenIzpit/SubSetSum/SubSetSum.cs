using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubSetSum
{
    class SubSetSum
    {
        static void Main(string[] args)
        {
//You are given a list of N numbers. Write a program that counts all non-empty subsets from this list, which have sum of 
//their elements exactly S.
//Example: if you have a list with 4 elements: { 1, 2, 3, 4 } and you are searching the number of non-empty subsets which sum
//is 4, the answer will be 2. The subsets are: { 1, 3 } and { 4 }.
//Input
//The input data is being read from the console. 
//On the first input line there will be the number S.
//On the second line you must read the number N.
//On each of the following N lines there will be one integer number written – all the numbers from the list.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output must be printed on the console.
//On the only output line you must print the number of the non-empty subsets, which have sum of all its elements exactly S.
//Constraints
//•	The number N is a positive integer between 1 and 16, inclusive.
//•	All of the N numbers are integer numbers and will be between -1 337 000 000 000 and 1 337 000 000 000, inclusive.
//•	The number S is an integer number between -21 392 000 000 000 and 21 392 000 000 000, inclusive.
//•	All of the N numbers will be distinct.

            //Console.WriteLine("{0:N}", double.MaxValue);
            //Console.WriteLine("{0:N}", double.MinValue);
            //Console.WriteLine("{0:N}", decimal.MinValue);
            //Console.WriteLine("{0:N}", decimal.MinValue);

            string readSum = Console.ReadLine();
            long sum = long.Parse(readSum);

            string readNNumbers = Console.ReadLine();
            byte nNumbers = byte.Parse(readNNumbers);

            long[] sequenceOfNumbers = new long[nNumbers];

            for (int i = 0; i < nNumbers; i++)
            {
                string readNumber = Console.ReadLine();
                long number = long.Parse(readNumber);

                sequenceOfNumbers[i] = number;
            }

            long counter = 0;
            long countCurrentLengthOfSequences = 0;

            long currentNumber = 0;
            long result = 0;

            for (long j = countCurrentLengthOfSequences; j < sequenceOfNumbers.Length; j++)
            {
                result = sequenceOfNumbers[j];

                if (result == sum)
                {
                    counter++;
                }
            }

            long currentLengthOfSequences = 1;
            long nextIndex = 0;
            long length = sequenceOfNumbers.Length;

            if (length > 1)
            {
                while (true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine("veryFirstFor");
                        result = 0;
                        currentNumber = 0;
                        countCurrentLengthOfSequences = 0;

                        if ((countCurrentLengthOfSequences < currentLengthOfSequences) &&
                            ((i + currentLengthOfSequences) < length))
                        {
                            Console.WriteLine("O");
                            for (int x = i; x < i + currentLengthOfSequences; x++)
                            {
                                Console.WriteLine("irstFor");
                                currentNumber = currentNumber + sequenceOfNumbers[x];
                                countCurrentLengthOfSequences++;
                                nextIndex = x;
                            }
                        }
                        else
                        {
                            Console.WriteLine("F");
                            break;
                        }

                        nextIndex++;

                        if (nextIndex < length)
                        {
                            Console.WriteLine("SecondIF");
                            for (long j = nextIndex; j < length; j++)
                            {
                                result = currentNumber + sequenceOfNumbers[j];

                                if (result == sum)
                                {
                                    counter++;
                                }
                            }
                        }                       
                        else
                        {
                            Console.WriteLine("F1");
                            break;
                        }
                    }

                    currentLengthOfSequences++;
                    Console.WriteLine("A");
                    if (currentLengthOfSequences == length)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}