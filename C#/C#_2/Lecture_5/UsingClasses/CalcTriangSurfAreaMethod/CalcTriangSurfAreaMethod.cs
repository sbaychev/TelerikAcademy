using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcTriangSurfAreaMethod
{
    class CalcTriangSurfAreaMethod
    {
        static void Main(string[] args)
        {
        //Write methods that calculate the surface of a triangle by given: Use System.Math.
        //Side and an altitude to it; Three sides; Two sides and an angle between them. 
            double a = 3.0d; //double.Parse(Console.ReadLine());
            double b = 4.0d; //double.Parse(Console.ReadLine());
            double c = 5.0d; // double.Parse(Console.ReadLine());
            double latA = 4.0d; // double.Parse(Console.ReadLine());
            double latB = 3.0d;//double.Parse(Console.ReadLine());
            double latC = 2.4d;//double.Parse(Console.ReadLine());
            double angA = 36.87;//double.Parse(Console.ReadLine());
            double angB = 53.13;//double.Parse(Console.ReadLine());
            double angC = 90.0;//double.Parse(Console.ReadLine());
            double surfAreaSide = SurfAreaSides(a, b, c);
            Console.WriteLine(surfAreaSide);
            double surfAreaLati = SurfAreaLat(b, latB);
            Console.WriteLine(surfAreaLati);
            double surfAreaAn = SurfAreaAng(a, b, angC);
            Console.WriteLine(surfAreaAn);
        }
        static double SurfAreaSides(double numA, double numB, double numC)
        {
            //[s(s-a)(s-b)(s-c)] when s = (a+b+c)/2
            double halP = (numA + numB + numC) / 2;
            double surfArea = (halP*(halP-numA)*(halP-numB)*(halP-numC));
            surfArea = Math.Sqrt(surfArea);
            return surfArea;
        }
        static double SurfAreaLat(double numX, double latX)
        {
            //triangle = (1/2) b h 
            double surfArea = (numX * latX) * 0.5;
            return surfArea;
        }
        static double SurfAreaAng(double numY, double numZ, double angW)
        {
            //triangle given SSA = (1/2) a b sin C
            double surfArea = (numY * numZ) * 0.5 * Math.Round(Math.Sin(angW));
            return surfArea;
        }
    }
}