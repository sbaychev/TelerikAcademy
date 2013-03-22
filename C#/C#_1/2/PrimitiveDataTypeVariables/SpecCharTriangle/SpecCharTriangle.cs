using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecCharTriangle
{
    class SpecCharTriangle
    {
        static void Main(string[] args)
        {
            /*Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the 
             * Unicode code of the © symbol.*/
            char symbol = '\u00a9';
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int row = 0; row < 3; row++)
            {
                
                Console.WriteLine(new string(symbol, row + 1));
            }
            for (int row = 1; row < 3; row++)
            {
                
                Console.WriteLine(new string(symbol, 3 - row));
            }                                              //The result is a visual approximation of an isosceles triangle that
            Console.Write("\nPress any key to continue.");//has 9 © symbols altogether for its construction as per the task requirements
            Console.ReadKey();
        }
    }
}