using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastDigitInEngl
{
    class LastDigitInEngl
    {
        static void Main(string[] args)
        {
            // Write a method that returns the last digit of given integer as an English word. 
            //Examples: 512  "two", 1024  "four", 12309  "nine".
            int num = int.Parse(Console.ReadLine());
            LastDigAsEngl(num);
        }
        static void LastDigAsEngl(int num)
        {
            string strNum = num.ToString();
            string last = strNum.Substring(strNum.Length - 1, 1);
            int numLast = int.Parse(last);
            if (numLast == 0)
            {
                Console.WriteLine("{0} -> zero", num);
            }
            else if (numLast == 1)
            {
                Console.WriteLine("{0} -> one", num);
            }
            else if (numLast == 2)
            {
                Console.WriteLine("{0} -> two", num);
            }
            else if (numLast == 3)
            {
                Console.WriteLine("{0} -> three", num);
            }
            else if (numLast == 4)
            {
                Console.WriteLine("{0} -> four", num);
            }
            else if (numLast == 5)
            {
                Console.WriteLine("{0} -> five", num);
            }
            else if (numLast == 6)
            {
                Console.WriteLine("{0} ->six", num);
            }
            else if (numLast == 7)
            {
                Console.WriteLine("{0} -> seven", num);
            }
            else if (numLast == 8)
            {
                Console.WriteLine("{0} -> eight", num);
            }
            else if (numLast == 9)
            {
                Console.WriteLine("{0} -> nine", num);
            }
        }
    }
}
