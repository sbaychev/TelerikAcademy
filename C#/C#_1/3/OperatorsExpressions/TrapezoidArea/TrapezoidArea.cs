using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h
            Console.Write("Enter side a of the trapezoid: ");
            string consA = Console.ReadLine();
            double sideA = double.Parse(consA);
            Console.Write("\nEnter side b of the trapezoid: ");
            string consB = Console.ReadLine();
            double sideB = double.Parse(consB);
            Console.Write("\nEnter the height of the trapezoid: ");
            string consH = Console.ReadLine();
            double sideH = double.Parse(consH);
            double area = ( ((Math.Abs(sideA) + Math.Abs(sideB))/2) * Math.Abs(sideH) );
            Console.WriteLine("\nThe Area of the Trapezoid is: {0}",area);
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}