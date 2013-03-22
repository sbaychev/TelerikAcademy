using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadiusPerArea
{
    class RadiusPerArea
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area.
            Console.Write("Please Enter the Radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * (Math.Pow(radius, 2));
            double perimCircle = 2 * Math.PI * radius;
            Console.Write("\nThe Perimiter of the Circle is: {0}", perimCircle);
            Console.Write("\n\nThe Area of the Circle is: {0}\n", areaCircle);
        }
    }
}