using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoIntGreaterExch
{
    class TwoIntGreaterExch
    {
        static void Main(string[] args)
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater 
            //than the second one.
            //byte a = 1;
            //byte b = 85;
            //bool isEven;
            //Console.WriteLine(a & b);

            Console.WriteLine("Please enter two integer values (on separate lines, press Enter inbetween).");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            int biggerNumber = firstInt;
            if (firstInt == secondInt)
            {
                Console.WriteLine("\nThe two integer numbers {0} and {1} are equal", firstInt, secondInt);
            }
            else if (secondInt > firstInt)
            {
                biggerNumber = secondInt;
                Console.WriteLine("\nThe First and Second Integer values stay the same, because\nthe Second Integer is Greater than the First");
            }
            else
            {
                firstInt = secondInt;
                secondInt = biggerNumber;
                Console.WriteLine("\nThe First one is Greater than the Second one and we are now exchanging their\nvalues, where firstInt now is {0} and secondInt now is {1}", firstInt, secondInt);
            }
        }
    }
}