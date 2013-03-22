using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PointWithinCircAndRect
{
    class PointWithinCircAndRect
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
            //and out of the rectangle R(top=1, left=-1, width=6, height=2).
            Console.Write("Enter the x coordinate of the point: ");
            string xCons = Console.ReadLine();
            int xPointCor = int.Parse(xCons);
            Console.Write("Enter the y coordinate of the point: ");
            string yCons = Console.ReadLine();
            int yPointCor = int.Parse(yCons);
            int xCirCor = 1;
            int yCirCor = 1;
            int radCir = 3;
            Rectangle rectObjOne = new Rectangle(1, -1, 6, 2); //I would assume that the top = 1 and left = -1 are respectively the x and y coordinates of the upper left x and y of the rectangle
            Point pointObjeOne = new Point(xPointCor, yPointCor);
            if ( (Math.Pow( (xPointCor - xCirCor), 2) + Math.Pow( (yPointCor - yCirCor), 2) < Math.Pow(radCir, 2)) ) // or for the rect ((x1 <= pointX <= x2) && (y1 <= pointY <= y2)) where the x and y are coordinates of the rect
            {
                if (rectObjOne.Contains(pointObjeOne))
                {
                    Console.Write("\nThe given point with the provided x and y coordinates is within\na Circle with coordinates K(1, 1), radius 3 and within the\nrectangle R(top=1, left=-1, width=6, height=2)\n");
                    Console.Write("\nPress any key to exit.");
                    Console.ReadKey();
                    return;
                }                            
                Console.Write("\nThe given point with the provided x and y coordinates is within\na Circle with coordinates K(1, 1), radius 3 and OUT of the\nrectangle R(top=1, left=-1, width=6, height=2)\n");
            }
            else if (rectObjOne.Contains(pointObjeOne))
            {
                Console.Write("\nThe given point with the provided x and y coordinates is NOT within\na Circle with coordinates K(1, 1), radius 3, but is within the\nrectangle R(top=1, left=-1, width=6, height=2)\n");
                Console.Write("\nPress any key to exit.");
                Console.ReadKey();
                return;                
            }
            else
            {
                Console.Write("\nThe given point with the provided x and y coordinates\n\nis NOT within a Circle with coordinates K(1, 1), radius 3 and is OUT of\nthe rectangle R(top=1, left=-1, width=6, height=2)\n");
            }
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
            }
    }
}