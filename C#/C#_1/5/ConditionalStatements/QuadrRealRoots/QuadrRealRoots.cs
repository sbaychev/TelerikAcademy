using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadrRealRoots
{
    class QuadrRealRoots
    {
        static void Main(string[] args)
        {
        //    Write a program that enters the coefficients a, b and c of a quadratic equation
        //a*x2 + b*x + c = 0
        //and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
            Random random = new Random();
            double varA = random.Next();
            double varB = random.Next();
            double varC = random.Next();
            double varXOne = 0.0d;
            double varXTwo = 0.0d;
            double varDiscrim = (((varB) * (varB)) - 4 * (varA * varC));

            Console.WriteLine("The equation's Discriminant is {0}", varDiscrim);
            if (varDiscrim < 0)
            {
                Console.Write("\nThe equation has no real roots\n\n");
            }
            else if (varDiscrim > 0)
            {
                varXOne = ((((-1) * (varB)) - (Math.Sqrt(varDiscrim))) / (2 * varA));
                varXTwo = ((((-1) * (varB)) + (Math.Sqrt(varDiscrim))) / (2 * varA));
                Console.Write("\nThe equation has two real roots\nx1 = {0} and x2 = {1}\n\n", varXOne, varXTwo);
            }
            else if (varDiscrim == 0)
            {
                Console.Write("\nThe equation has one real root\nx1 = x2 = {0}\n\n", (-(varB / (2 * varA))));
            } 
        }
    }
}