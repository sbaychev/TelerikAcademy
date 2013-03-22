using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i < (N / 2) + 1)
                    {
                        if (i == j && j != (N / 2) + 1 && j != N + 1 - i)
                        {
                            Console.Write("\\");
                        }
                        else if (j == N + 1 - i)
                        {
                            Console.Write("/");
                        }
                        else if (j == (N / 2) + 1 && i != (N / 2) + 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                    if (i == (N / 2) + 1)
	                {
                        if (j == (N / 2) + 1)
	                    {
		                     Console.Write("*");
	                    }
                        else
                        {
                            Console.Write("-");
                        }
	                }
                    if (i > (N / 2) + 1)
	                {
                        if (i == j && j != (N / 2) + 1 && j != N + 1 - i)
                        {
                            Console.Write("\\");
                        }
                        else if (j == N + 1 - i)
                        {
                            Console.Write("/");
                        }
                        else if (j == (N / 2) + 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(".");
                        }
	                }
                }
                Console.WriteLine();
            }
        }
    }
}