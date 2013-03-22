using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1ShipDamage
{
    class Problem1ShipDamage
    {
//Inside the sea (a standard Cartesian /rectangular/ coordinate system) we are given a ship S (a rectangle whose sides are parallel to 
//the coordinate axes), a horizontal line H (the horizon) and three catapults, given as coordinates C1, C2 and C3 that will be used to 
//fire the ship. When the attack starts, each catapult hits a projectile exactly into the positions that are symmetrical to C1, C2 and 
//C3 with respect to the horizon H. When a projectile hits some of the corners of the ship, it causes a damage of 25%, when it hits some
//of the sides of the ship, the damage caused is 50% and when it hits the internal body of the ship, the damage is 100%. When the 
//projectile hit outside of the ship, there is no damage. The total damage is sum of the separate damages and can exceed 100%.
//At the figure below a sea, a ship S, a line H, three points C1, C2 and C3 and their hit positions are shown:
 
//Your task is to write a program that calculates the total damage caused after the attack over the ship.
//Input
//The input data should be read from the console.
//There will be exactly 11 lines holding the integer numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3. The ship S is 
//given by any two of its opposite corners and is non-empty (has positive width and height). The line H is given by its vertical offset.
//The points C1, C2 and C3 are given as couples of coordinates and cannot overap each other.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output should consist of a single line holding the total damage given as percentage.
//Constraints
//•	The numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3 are all integers between -100 000 and 100 000, inclusive.

        static void Main(string[] args)
        {
            int SX1 = int.Parse(Console.ReadLine());
            int SY1 = int.Parse(Console.ReadLine());
            int SX2 = int.Parse(Console.ReadLine());
            int SY2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int CX1 = int.Parse(Console.ReadLine());
            int CY1 = int.Parse(Console.ReadLine());
            int CX2 = int.Parse(Console.ReadLine());
            int CY2 = int.Parse(Console.ReadLine());
            int CX3 = int.Parse(Console.ReadLine());
            int CY3 = int.Parse(Console.ReadLine());

            CY1 = CY1 + ( 2*(Math.Abs(CY1) + H) );
            CY2 = CY2 + ( 2*(Math.Abs(CY2) + H) );
            CY3 = CY3 + ( 2*(Math.Abs(CY3) + H));

            if (SY1 > SY2)
            {
                int temp = 0;
                temp = SY1;
                SY1 = SY2;
                SY2 = temp;
            }
            if (SX1 > SX2)
            {
                int temp = 0;
                temp = SX1;
                SX1 = SX2;
                SX2 = temp;
            }
            float hundr = 1.00f;
            float twentyFive = .25f;
            //in rect C1 -> ( (SX1 < CX1 && CX1 < SX2 ) && (SY1 < CY1 && CY1 < SY2) )
            //in rect C2 -> ( (SX1 < CX2 && CX2 < SX2 ) && (SY1 < CY2 && CY2 < SY2) )
            //in rect C3 -> ( (SX1 < CX3 && CX3 < SX2 ) && (SY1 < CY3 && CY3 < SY2) )

            if ( ((SX1 < CX1 && CX1 < SX2) && (SY1 < CY1 && CY1 < SY2)) || ((SX1 < CX2 && CX2 < SX2) && (SY1 < CY2 && CY2 < SY2)) || ((SX1 < CX3 && CX3 < SX2) && (SY1 < CY3 && CY3 < SY2)) )
            {
                if ( ((SX1 < CX1 && CX1 < SX2) && (SY1 < CY1 && CY1 < SY2)) && ((SX1 < CX2 && CX2 < SX2) && (SY1 < CY2 && CY2 < SY2)) && ((SX1 < CX3 && CX3 < SX2) && (SY1 < CY3 && CY3 < SY2)) )
                {
                    Console.WriteLine("{0:0%}", hundr + hundr + hundr);
                }
                else if ( ((SX1 < CX1 && CX1 < SX2) && (SY1 < CY1 && CY1 < SY2)) || ((SX1 < CX2 && CX2 < SX2) && (SY1 < CY2 && CY2 < SY2)) )
                {
                    if (((SX1 < CX1 && CX1 < SX2) && (SY1 < CY1 && CY1 < SY2)) && ((SX1 < CX2 && CX2 < SX2) && (SY1 < CY2 && CY2 < SY2)))
                    {
                        Console.WriteLine("{0:0%}", hundr + hundr);
                    }
                    else if (((SX1 < CX1 && CX1 < SX2) && (SY1 < CY1 && CY1 < SY2)))
                    {
                        Console.WriteLine("{0:0%}", hundr);
                    }
                }
            }
            else if (((SX1 <= CX1 && CX1 <= SX2) && (SY1 <= CY1 && CY1 <= SY2)) || ((SX1 <= CX2 && CX2 <= SX2) && (SY1 <= CY2 && CY2 <= SY2)) || ((SX1 <= CX3 && CX3 <= SX2) && (SY1 <= CY3 && CY3 <= SY2)))
            {
                
            }
            else
            {
                Console.WriteLine("{0:0%}", 0);
            }
        }
    }
}
           //int sx1 = Int32.Parse(Console.ReadLine());
           // int sy1 = Int32.Parse(Console.ReadLine());
           // int sx2 = Int32.Parse(Console.ReadLine());
           // int sy2 = Int32.Parse(Console.ReadLine());
           // int h = Int32.Parse(Console.ReadLine());
           // int cx1 = Int32.Parse(Console.ReadLine());
           // int cy1 = Int32.Parse(Console.ReadLine());
           // int cx2 = Int32.Parse(Console.ReadLine());
           // int cy2 = Int32.Parse(Console.ReadLine());
           // int cx3 = Int32.Parse(Console.ReadLine());
           // int cy3 = Int32.Parse(Console.ReadLine());

           // // Find the hit points (apply symmetrics)
           // cy1 = 2 * h - cy1;
           // cy2 = 2 * h - cy2;
           // cy3 = 2 * h - cy3;

           // // Find the ship bounds
           // int minX = Math.Min(sx1, sx2);
           // int maxX = Math.Max(sx1, sx2);
           // int minY = Math.Min(sy1, sy2);
           // int maxY = Math.Max(sy1, sy2);

           // int totalDamage = 0;

           // // Check the corners damage
           // if ((cx1 == minX || cx1 == maxX) && (cy1 == minY || cy1 == maxY))
           // {
           //     totalDamage += 25; // Hit in the corner
           // }
           // if ((cx2 == minX || cx2 == maxX) && (cy2 == minY || cy2 == maxY))
           // {
           //     totalDamage += 25; // Hit in the corner
           // }
           // if ((cx3 == minX || cx3 == maxX) && (cy3 == minY || cy3 == maxY))
           // {
           //     totalDamage += 25; // Hit in the corner
           // }

           // // Check the borders damage
           // if (((cx1 == minX || cx1 == maxX) && (cy1 > minY && cy1 < maxY)) ||
           //     ((cy1 == minY || cy1 == maxY) && (cx1 > minX && cx1 < maxX)))
           // {
           //     totalDamage += 50; // Hit in the border
           // }
           // if (((cx2 == minX || cx2 == maxX) && (cy2 > minY && cy2 < maxY)) ||
           //     ((cy2 == minY || cy2 == maxY) && (cx2 > minX && cx2 < maxX)))
           // {
           //     totalDamage += 50; // Hit in the border
           // }
           // if (((cx3 == minX || cx3 == maxX) && (cy3 > minY && cy3 < maxY)) ||
           //     ((cy3 == minY || cy3 == maxY) && (cx3 > minX && cx3 < maxX)))
           // {
           //     totalDamage += 50; // Hit in the border
           // }

           // // Check the internal body damage
           // if ((cx1 > minX) && (cx1 < maxX) && (cy1 > minY) && (cy1 < maxY))
           // {
           //     totalDamage += 100; // Hit in the internal body
           // }
           // if ((cx2 > minX) && (cx2 < maxX) && (cy2 > minY) && (cy2 < maxY))
           // {
           //     totalDamage += 100; // Hit in the internal body
           // }
           // if ((cx3 > minX) && (cx3 < maxX) && (cy3 > minY) && (cy3 < maxY))
           // {
           //     totalDamage += 100; // Hit in the internal body
           // }

           // Console.WriteLine(totalDamage + "%");