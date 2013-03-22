using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintsAllCardsInEnglish
{
    class PrintsAllCardsInEnglish
    {
        // Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
        //The cards should be printed with their English names. Use nested for loops and switch-case.
        static void Main(string[] args)
        {
            string[] suits = { "spades", "harts", "diamonds", "clubs" };
            for (int i = 2; i < 15; i++)
            {
                if (i == 2)
                {
                    string two = " two ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", two, suits[k]);
                    }
                }
                if (i == 3)
                {
                    string three = " three ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", three, suits[k]);
                    }
                }
                if (i == 4)
                {
                    string four = " four ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", four, suits[k]);
                    }
                }
                if (i == 5)
                {
                    string five = " five ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", five, suits[k]);
                    }
                }
                if (i == 6)
                {
                    string six = " six ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", six, suits[k]);
                    }
                }
                if (i == 7)
                {
                    string seven = " seven ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", seven, suits[k]);
                    }
                }
                if (i == 8)
                {
                    string eight = " eight ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", eight, suits[k]);
                    }
                }
                if (i == 9)
                {
                    string nine = " nine ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", nine, suits[k]);
                    }
                }
                if (i == 10)
                {
                    string ten = " ten ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", ten, suits[k]);
                    }
                }
                if (i == 11)
                {
                    string jack = " jack ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", jack, suits[k]);
                    }
                }
                if (i == 12)
                {
                    string queen = " queen ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", queen, suits[k]);
                    }
                }
                if (i == 13)
                {
                    string king = " king ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", king, suits[k]);
                    }
                }
                if (i == 14)
                {
                    string ace = " ace ";
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("{0} of {1}", ace, suits[k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}