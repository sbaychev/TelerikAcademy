using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareTwoNum
{
    class CompareTwoNum
    {
        public static void nearlyEqual(float a, float b, float epsilon) //used method algorithm from http://floating-point-gui.de/errors/comparison/
        {
            float absA = Math.Abs(a);
            float absB = Math.Abs(b);
            float diff = Math.Abs(a - b);

            if (a == b) 
            { // shortcut, handles infinities 
                Console.Write("Correct, the {0} and {1} floating-point values are equal", a, b);
                Console.Write("\n");
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
                return;
            } 
            else if (a * b == 0) 
            { // a or b or both are zero
                // relative error is not meaningful here
                if(diff < (epsilon * epsilon))
                {
                    Console.Write("The {0} and {1} floating-point values are either both zero or one of them is", a, b);
                    Console.Write("\n");
                    Console.Write("\nPress any key to exit.");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("The floating-point values {0} and {1} are not equal", a, b);
                Console.Write("\nPress any key to exit.");
                Console.ReadKey();
                return;
            } 
            else 
            { // use relative error
                if ( diff / (absA + absB) < epsilon)
                {
                    Console.WriteLine("Relative Calculation Error");
                    Console.Write("\nPress any key to exit.");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("The floating-point values {0} and {1} are not equal", a, b);
                Console.Write("\nPress any key to exit.");
                Console.ReadKey();
                return;
            }
        }
        static void Main(string[] args)
        {
            /*Write a program that safely compares floating-point numbers with precision of 0.000001.*/
            float fNum1 = 5.00000001f;
            //float fNum1 = 6.000001f;
            float fNum2 = 5.00000003f;
            //float fNum2 = 6f;
            float precision = 0.000001f;
            nearlyEqual(fNum1, fNum2, precision);
            //if ((((Math.Abs(fNum1) - Math.Abs(fNum2)) - precision) < 0) && (0 == (Math.Abs(fNum1 - fNum2))))
            //{
            //    /*up above I have picked two different positive 7 digit numbers (just for examplary purposes) of floating-point 
            //     * type that even when interchanged with +/- or -- signs produce correct answer and the if check makes sure that 
            //     * up to the 7th sign the answer is correct (because of the task's requirement for a 0.000001 precision)*/
            //    Console.Write("Correct, the {0} and {1} floating-point values are equal", fNum1, fNum2);
            //    Console.Write("\n");
            //    Console.WriteLine("\nPress any key to exit.");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.Write("The {0} and {1} floating-point values are Not equal", fNum1, fNum2);
            //    Console.Write("\n");
            //    Console.WriteLine("\nPress any key to exit.");
            //    Console.ReadKey();
            //}
        }
    }
}