using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckPointIfInCircle
{
    class CheckPointIfInCircle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x,  y) is within a circle K(O, 5)
            //In order for us to do the stated we would need to have a radius of the given circle 
            //and I would take it to be 5 and the Circle would have coordinates K(0, 5)
            Console.Write("Enter the x coordinate of the point: ");
            string xCons = Console.ReadLine();
            int xPointCor = int.Parse(xCons);
            Console.Write("Enter the y coordinate of the point: ");
            string yCons = Console.ReadLine();
            int yPointCor = int.Parse(yCons);
            int xCorCir = 0;
            int yCorCir = 5;
            int radCir = 5;
            if(Math.Pow((xPointCor - xCorCir), 2) + Math.Pow((yPointCor - yCorCir), 2) < Math.Pow(radCir, 2))
            {
                Console.Write("\nThe given point with the provided x and y coordinates is within\na Circle with center coordinates K(0, 5) and radius 5\n");
            }
            else
            {
                Console.Write("\nThe given point with the provided x and y coordinates\n\nis NOT within a Circle with center coordinates K(0, 5) and radius 5\n");
            }
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
