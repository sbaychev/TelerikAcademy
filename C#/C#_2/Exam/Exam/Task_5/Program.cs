using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static bool IsPalindrome(ulong n)
        {

            long index = 0;
            bool palindrome = true;
            ulong[] digits = new ulong[n.ToString().Length];
            do
            {
                digits[index++] = n % 10;
                n = n / 10;
            } while (n > 0);
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    Console.WriteLine("one");
            //    Console.WriteLine(digits[i]);
            //    if (digits[i] != 5 || digits[i] != 3)
            //    {
            //        Console.WriteLine("pre");
            //        Console.WriteLine();
            //        return false;
            //    }
            //}
            for (int i = 0; i < index / 2 + 1; i++)
            {
                if (digits[i] != digits[index - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            if (palindrome == true)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //ulong a = 35;
            //ulong b = 53;
            int count = 0;
            string aAndB = Console.ReadLine();
            string[] tAndB = aAndB.Split(' ');
            ulong a = ulong.Parse(tAndB[0]);
            ulong b = ulong.Parse(tAndB[1]);
            string listNums = Console.ReadLine();
            string[] t = listNums.Split(',');
            List<int> nums = new List<int>();
            for (int i = 0; i < t.Length; i++)
            {
                nums.Add(int.Parse(t[i]));
            }
            //-2, -1, -4, -3//1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            nums.Sort();
            int p = int.Parse(Console.ReadLine());
            int rank = (int)Math.Round((((double)p / (double)100) * nums.Count) + (double)(1 / 2));
            for (ulong i = a; i <= b; i++)
            {

                if ((i / (ulong)Math.Pow(10, i.ToString().Length - 1) == 5) || (i / (ulong)Math.Pow(10, i.ToString().Length - 1) == 3))
                {
                    if (IsPalindrome(i))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(nums[rank - 1]);
        }
    }
}