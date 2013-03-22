using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBiggestThreeInt
{
    class TheBiggestThreeInt
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers using nested if statements.
            Console.WriteLine("Please enter three integer numbers (on separate lines, press Enter inbetween).");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            if (firstInt >= secondInt && firstInt >= thirdInt)
            {
                Console.WriteLine("The first integer {0} is Greater or equal to any of the other two {1} and {2}",
                        firstInt, secondInt, thirdInt);
            }
            else
            {
                if(secondInt >= thirdInt)
	            {
		            Console.WriteLine("The second integer {0} is Greater or equal to any of the other two {1} and {2}",
                       secondInt, thirdInt, firstInt);
                }
                else
                {
                    Console.WriteLine("The third integer {0} is Greater to the other two {1} and {2}",
                         thirdInt, firstInt, secondInt);
                }
            }
        }            
     }
}