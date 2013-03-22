using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            int[] a = {1, 5, 2, 4, 2, 6, 66, 0, -1, 100, 3, 10, 20 };
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i- 1] > a [i])
                    {
                        int temp = a[i - 1];
                        a[i - 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(now);
        }
    }
}
