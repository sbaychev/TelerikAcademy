using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneToN
{
    class OneToN
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N.
            Console.Write("N= ");
            int varN = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= varN; i++) //including N
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
