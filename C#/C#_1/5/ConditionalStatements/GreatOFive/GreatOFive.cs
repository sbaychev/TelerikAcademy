using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreatOFive
{
    class GreatOFive
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 variables.
            Random random = new Random();
            int [] fiveVar = new int[5];
            int greater = fiveVar[0];
            for (int i = 0; i < fiveVar.Length; i++)
            {
                fiveVar[i] = random.Next(0, 100);
            }
            for (int i = 0; i < fiveVar.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, fiveVar[i]);
            }
            for (int i = 0; i < fiveVar.Length; i++)
            {
                greater = fiveVar[i] > greater ? fiveVar[i] : greater;
            }
            Console.WriteLine("\nThe Greatest of given 5 variables: {0}\n", greater);
        }
    }
}