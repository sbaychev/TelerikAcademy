﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine(a);
        }
    }
}