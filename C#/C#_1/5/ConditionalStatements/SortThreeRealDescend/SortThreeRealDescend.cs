using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortThreeRealDescend
{
    class SortThreeRealDescend
    {
        static void Main(string[] args)
        {
            //Sort 3 real values in descending order using nested if statements.
            Console.WriteLine("Please enter three integer numbers (on separate lines, press Enter inbetween).");
            int firstR = int.Parse(Console.ReadLine());
            int secondR = int.Parse(Console.ReadLine());
            int thirdR = int.Parse(Console.ReadLine());

            if (firstR >= secondR && firstR >= thirdR)
            {
                if (secondR >= thirdR)
                {
                    Console.WriteLine("\n{0} {1} {2}", firstR, secondR, thirdR);
                }
                else
                {
                    Console.WriteLine("\n{0} {1} {2}", firstR, thirdR, secondR);
                }
            }
            else
            {
                if (secondR >= thirdR)
                {
                    if (firstR >= thirdR)
                    {
                        Console.WriteLine("\n{0} {1} {2}",
                                 secondR,firstR, thirdR);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} {1} {2}",
                                 secondR, thirdR, firstR);
                    }
                }
                else
                {
                    if (firstR >= thirdR)
                    {
                        Console.WriteLine("\n{0} {1} {2}",
                            firstR, thirdR, secondR);
                    }
                    else if (secondR >= firstR)
                    {
                        Console.WriteLine("\n{0} {1} {2}",
                             thirdR, secondR, firstR);//when the first is the smallest
                    }
                    else
                    {
                        Console.WriteLine("\n{0} {1} {2}",
                             thirdR, firstR, secondR);
                    }
                }
            }
        }
    }
}