using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            BigInteger current = BigInteger.Parse(Console.ReadLine());
            BigInteger next = BigInteger.Parse(Console.ReadLine());
            BigInteger twoAway = BigInteger.Parse(Console.ReadLine());
            BigInteger threeAway = BigInteger.Parse(Console.ReadLine());
            BigInteger fourAway = 0;
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            Console.Write(current);
            Console.Write(" {0}", next);
            Console.Write(" {0}", twoAway);
            Console.Write(" {0}", threeAway);

                for (int i = 3; i < R * C - 1; i++)
                {
                    Console.Write(" ");
                    if (((i + 1) % C) == 0)
                    {
                        Console.WriteLine();
                    }
                    fourAway = current + next + twoAway + threeAway;
                    current = next;
                    next = twoAway;
                    twoAway = threeAway;
                    threeAway = fourAway;
                    Console.Write(fourAway);
                }
        }
    }
}