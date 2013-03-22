using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistCombNandK
{
    class DistCombNandK
    {
        static void Main(string[] args)
        {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the 
        //set [1..N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
            //int n = 5;
            //int k = 2;
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            foreach (int[] c in Combinations(n, k))
            {
                Console.Write("{");
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == c.Length - 1)
                    {
                        Console.Write(c[i]);
                    }
                    else
                    {
                        Console.Write(c[i] + ", ");
                    }
                   
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }

        public static IEnumerable<int[]> Combinations(int n, int k)
        {
            int[] result = new int[k];
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            //Console.WriteLine(stack.Count);

            while (stack.Count > 0)
            {
                //Console.WriteLine(stack.Count);
                int index = stack.Count - 1;
                int value = stack.Pop();
                //Console.WriteLine(index);
                //Console.WriteLine(value);
                //Console.WriteLine();

                while (value <= n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index == k)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }       
    }
}