using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryDigitCountExamSample04
{
    class BinaryDigitCountExamSample04
    {
        static void Main()
        {
            // Read input
            byte B = byte.Parse(Console.ReadLine());
            short N = short.Parse(Console.ReadLine());
 
            // Solve
            for (int i = 1; i <= N; i++)
            {
                int count = 0;
                uint number = uint.Parse(Console.ReadLine());//here the N - i number is read
                while (number != 0)//here we do the bellow given operations up until we get to 0;
                {
                    if ((number & 1) == B) //here we do make sure that if at position 1 the 0 or 1(e.g.0001) - the B, is caught 
                    {                      //and compared to the value of B up until the while "expires" and we have made 
                        count++;           //the needed counts respectfully
                    }
                    number = number >> 1; //we are moving the index of the number one position to the right - 
                }                         //in order to compare it once again up above
 
                // Write answers
                Console.WriteLine(count); //display the result of count for the speciffic Nth number
            }
        }
    }
}