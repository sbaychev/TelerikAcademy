using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectArea
{
    class RectArea
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s area by given width and height
            Console.Write("Enter the width of the rectagle: ");
            string num = Console.ReadLine();
            double width, height;
            if (!double.TryParse(num, out width))
            {
                Console.Write("\nYou Have Not Entered a Floating Type Number, Next Time Pleaso Do!");
                Console.ReadKey();
                return;
            }
            Console.Write("\nEnter the height of the rectagle: ");
            string num1 = Console.ReadLine();
            if (!double.TryParse(num1, out height))
            {
                Console.Write("\nYou Have Not Entered a Floating Type Number, Next Time Pleaso Do!");
                Console.ReadKey();
                return;
            }
            double area = Math.Abs(width) * Math.Abs(height);
            Console.WriteLine("\nThe area of the rectangle is: {0}", area);
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}