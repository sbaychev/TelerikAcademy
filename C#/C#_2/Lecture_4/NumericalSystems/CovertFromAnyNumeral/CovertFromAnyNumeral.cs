using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovertFromAnyNumeral
{
    class CovertFromAnyNumeral
    {
        static void Main(string[] args)
        {
            //Write a program to convert from any numeral system of given base s 
            //to any other numeral system of base d (2 ≤ s, d ≤  16).          

            string input = Console.ReadLine();
            int resultTemp = 0;
            string result = "";
            int baseS = int.Parse(Console.ReadLine());
            int baseD = int.Parse(Console.ReadLine());
            //Convert to decimal (10) base system number
            for (int i = 0; i < input.Length; i++)
            {
                resultTemp += Convert.ToInt32(input.Substring(i, 1)) * (int)Math.Pow(baseS, input.Length - 1 - i);
            }
            //Convert to d base system number
            while (resultTemp > 0)
            {
                switch (resultTemp % baseD)
                {
                    case 0: result += "0"; break;
                    case 1: result += "1"; break;
                    case 2: result += "2"; break;
                    case 3: result += "3"; break;
                    case 4: result += "4"; break;
                    case 5: result += "5"; break;
                    case 6: result += "6"; break;
                    case 7: result += "7"; break;
                    case 8: result += "8"; break;
                    case 9: result += "9"; break;
                    case 10: result += "a"; break;
                    case 11: result += "b"; break;
                    case 12: result += "c"; break;
                    case 13: result += "d"; break;
                    case 14: result += "e"; break;
                    case 15: result += "f"; break;
                    default: result += ""; break;
                }
                resultTemp = resultTemp / baseD;
            }
            //Reverse the string
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}