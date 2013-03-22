using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoPosNumRepAsArrDig
{
    class AddTwoPosNumRepAsArrDig
    {
        static void Main(string[] args)
        {
            //Write a method that adds two positive integer numbers represented as arrays of digits 
            //(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
            //Each of the numbers that will be added could have up to 10 000 digits

        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int[] firstArr = new int[num1.Length];//{ 1, 2, 3 };
        int[] secondArr = new int[num2.Length];
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < num1.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < num2.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = firstArr.Length - 1; i >= 0; i--)
        {
            sum1 += firstArr[i] * (int)Math.Pow(10, i);
        }
        for (int i = secondArr.Length - 1; i >= 0; i--)
        {
            sum2 += secondArr[i] * (int)Math.Pow(10, i);
        }
        Console.WriteLine(sum1 + sum2);
    }
  }
}