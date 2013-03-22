using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDecimalDigits
{
    class ReverseDecimalDigits
    {
        static void Main(string[] args)
        {
            //Write a method that reverses the digits of given decimal number. Example: 256  652
            int number = int.Parse(Console.ReadLine());//123;
            Console.WriteLine();
            Console.WriteLine(ReverseDigits(number));
        }
        static int ReverseDigits(int n)
        {
            int rev_number = 0;
            while (n > 0)
            {
                //Console.WriteLine(n);
                //Console.WriteLine(n % 10);
                rev_number = (rev_number * 10) + (n % 10);
                //Console.WriteLine(rev_number);
                n /= 10;
            }
            return rev_number;
        }
    }
}