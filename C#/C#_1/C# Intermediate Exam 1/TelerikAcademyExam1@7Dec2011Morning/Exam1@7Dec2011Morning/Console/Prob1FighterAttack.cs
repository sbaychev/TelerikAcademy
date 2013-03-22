using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Prob1FighterAttack
{
    class Prob1FighterAttack
    {
        //A rectangular plant P located in east-west direction is under attack by a fighter aircraft flying over it on the west. 
        //When the fighter launches a missile we have its coordinates F. It is assumed that the missile's direction is always 
        //straight on the west and the missile always hits the target after a fixed distance D in front of the fighter.
        //To simplify our model we assume the land is built of square cells of size 1 x 1 located in east-west direction and each cell
        //has integer Cartesian coordinates {x, y}. In this model the plant can be represented by a rectangular area of cell and the 
        //missile always hits some of the square cells (inside or outside of the plant).
        //When the missile hits a certain cell, the damage over it is 100%, on the cells staying on the left and on the right of it the
        //damage is 50% and in front of it the damage is 75%. The total damage is sum of the separate damages and can exceed 100%.
        //You are given the location of the plant P, the location of the fighter F and the distance D. Write a program that calculates
        //the damage over the plant after the attack. Note that the missile could hits the plant partially of fully or can hit some
        //area outside of the plant and cause no damage.
        //At the figure below a plant P, a fighter F, a distance D and the missile hit point are shown along with the damage caused 
        //over the cells by the hit. Note that some of the damaged cells are outside of the plant and thus the total damage is 225%:

        //Your task is to write a program that calculates the total damage caused after the attack over the plant.
        //Input
        //The input data should be read from the console. There will be exactly 7 lines holding the integer numbers 
        //PX1, PY1, PX2, PY2, FX, FY, and D. The plant P is given by the coordinates of any two of its opposite corners and is 
        //non-empty (consists of at least one cell). The location of the fighter is given as cell coordinates FX, and FY and the 
        //distance D is given as an integer number.
        //The input data will always be valid and in the format described. There is no need to check it explicitly.
        //Output
        //The output should consist of a single line holding the total damage given as percentage.
        //Constraints
        //•	The numbers PX1, PY1, PX2, PY2, FX, FY, and D are all integers in the range [-100 000 … 100 000].

        static void Main(string[] args)
        {
            int PX1 = int.Parse(Console.ReadLine());
            int PY1 = int.Parse(Console.ReadLine());
            int PX2 = int.Parse(Console.ReadLine());
            int PY2 = int.Parse(Console.ReadLine());
            int FX = int.Parse(Console.ReadLine());
            int FY = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            if (PY1 > PY2)
            {
                int temp = 0;
                temp = PY1;
                PY1 = PY2;
                PY2 = temp;
            }
            if (PX1 > PX2)
            {
                int temp = 0;
                temp = PX1;
                PX1 = PX2;
                PX2 = temp;
            }
            float hundr = 1.00f;
            float fifty = .50f;
            float sevFive = .75f;
            if ((PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY && FY <= PY2)) //(PX1<= (FX + D)<= PX2)&&(PY1<= (FY)<= PY2)
            {
                if ((PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2) || ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) || ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) ) )
                {
                    if ( ( (PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2) ) && ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) && ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) ) )
                    {
                        Console.WriteLine("{0:0%}", hundr + fifty + fifty + sevFive);
                    }
                    else if ( ( (PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2) ) || ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) )
                    {
                        if ( ( (PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2) ) && ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) )
                        {
                            Console.WriteLine("{0:0%}", hundr + fifty + sevFive);
                        }
                        else if ((PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2))
                        {
                            Console.WriteLine("{0:0%}", hundr + sevFive);
                        }
                        else
                        {
                            Console.WriteLine("{0:0%}", hundr + fifty);
                        }
                    }
                    else if (( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) || ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) ) ) 
                    {
                        if ( ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1<= PY2) ) && ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) ) )
                        {
                            Console.WriteLine("{0:%}", hundr + fifty + fifty);
                        }
                        else
                        {
                            Console.WriteLine("{0:0%}", hundr + fifty);
                        }
                    }
                    else if (  ( (PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2) ) || ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) ) )
                    {
                        if ( ( (PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2)) && ( (PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1<= PY2) )  )
                        {
                            Console.WriteLine("{0:0%}", hundr + fifty + sevFive);
                        }
                        else if ((PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2))
                        {
                            Console.WriteLine("{0:0%}", hundr + sevFive);
                        }
                        else
                        {
                            Console.WriteLine("{0:0%}", hundr + fifty);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0:0%}", hundr);
                }
            }
            else if ((PX1 <= (FX + D + 1) && (FX + D + 1) <= PX2) && (PY1 <= FY && FY <= PY2))
            {
                Console.WriteLine("{0:0%}", sevFive);
            }
            else if ((PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY + 1 && FY + 1 <= PY2))
            {
                Console.WriteLine("{0:0%}", fifty);
            }
            else if ((PX1 <= (FX + D) && (FX + D) <= PX2) && (PY1 <= FY - 1 && FY - 1 <= PY2))
            {
                Console.WriteLine("{0:0%}", fifty);
            }
            else
            {
                Console.WriteLine("{0:0%}", 0);
            }
        }
    }
}

            //int px1 = Int32.Parse(Console.ReadLine());
            //int py1 = Int32.Parse(Console.ReadLine());
            //int px2 = Int32.Parse(Console.ReadLine());
            //int py2 = Int32.Parse(Console.ReadLine());
            //int fx = Int32.Parse(Console.ReadLine());
            //int fy = Int32.Parse(Console.ReadLine());
            //int d = Int32.Parse(Console.ReadLine());

            //// Find the plant bounds
            //int minX = Math.Min(px1, px2);
            //int maxX = Math.Max(px1, px2);
            //int minY = Math.Min(py1, py2);
            //int maxY = Math.Max(py1, py2);

            //// Find the hit points
            //int hitX = fx + d;
            //int hitY = fy;
            //int hitUpX = hitX;
            //int hitUpY = hitY - 1;
            //int hitDownX = hitX;
            //int hitDownY = hitY + 1;
            //int hitRightX = hitX + 1;
            //int hitRightY = hitY;

            //// Calculate the damage over the plant
            //int totalDamage = 0;
            //if (hitX >= minX && hitX <= maxX && hitY >= minY && hitY <= maxY)
            //{
            //    totalDamage += 100;
            //}
            //if (hitUpX >= minX && hitUpX <= maxX && hitUpY >= minY && hitUpY <= maxY)
            //{
            //    totalDamage += 50;
            //}
            //if (hitDownX >= minX && hitDownX <= maxX && hitDownY >= minY && hitDownY <= maxY)
            //{
            //    totalDamage += 50;
            //}
            //if (hitRightX >= minX && hitRightX <= maxX && hitRightY >= minY && hitRightY <= maxY)
            //{
            //    totalDamage += 75;
            //}

            //// Print the damage
            //Console.WriteLine(totalDamage + "%");