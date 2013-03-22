using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCoefQuadEqRoots
{
    class ReCoefQuadEqRoots
    {
        static void Main(string[] args)
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
            //and solves it (prints its real roots)
            Console.Write("a= ");
            double varA = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double varB = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double varC = double.Parse(Console.ReadLine());
            double varXOne = 0.0d;
            double varXTwo = 0.0d;
            double varDiscrim = (((varB)*(varB)) -4*(varA*varC));
            Console.WriteLine("The equation's Discriminant is {0}",varDiscrim);
            if (varDiscrim < 0)
            {
                Console.Write("\nThe equation has no real roots\n\n");
            }
            else if (varDiscrim > 0)
            {
                varXOne = ((((-1)*(varB)) - (Math.Sqrt(varDiscrim))) / (2 * varA));
                varXTwo = ((((-1)*(varB)) + (Math.Sqrt(varDiscrim))) / (2 * varA));
                Console.Write("\nThe equation has two real roots x1 = {0} and x2 = {1}\n\n", varXOne, varXTwo);
            }
            else if (varDiscrim == 0)
            {
                Console.Write("\nThe equation has two real roots x1 = x2 = {0}\n\n", (-(varB / (2 * varA))));
            } 
        }
    }
}