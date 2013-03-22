using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenRanValInBetwHundrAndTwoHund
{
    class TenRanValInBetwHundrAndTwoHund
    {
        static void Main(string[] args)
        {
            //Write a program that generates and prints to the console 10 random values 
            //in the range [100, 200].
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+ ". ");
                RanNumGen();
            }
        }
        static Random r = new Random();
        static void RanNumGen()
        {
            int n = r.Next(100, 200);
            Console.WriteLine(n);
        }
    }
}
