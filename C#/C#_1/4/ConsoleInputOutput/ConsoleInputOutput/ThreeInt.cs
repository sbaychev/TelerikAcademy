using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeInt
{
    class ThreeInt
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum
            Console.Write("n1: ");
            int varN1 = int.Parse(Console.ReadLine());
            Console.Write("\nn2: ");
            int varN2 = int.Parse(Console.ReadLine());
            Console.Write("\nn3: ");
            int varN3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nn1 + n2 + n3 = {0}\n", (varN1+varN2+varN3));
        }
    }
}
