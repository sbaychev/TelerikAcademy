using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsReadStrPrintLetAndTimesLet
{
    class ConsReadStrPrintLetAndTimesLet
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and prints all 
            //different letters in the string along with information how many times each 
            //letter is found. 
            string str = Console.ReadLine();
            char[] charStr = str.ToLower().ToCharArray();
            char[] letter = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int[] times = new int[26];
            //for (int i = 0; i < charStr.Length; i++)
            //{
            //    Console.Write(charStr[i]);
            //}
            #region TimesLetters
            for (int i = 0; i < charStr.Length; i++)
            {
                switch (charStr[i])
                {
                    case 'a':
                        times[0]++;
                        break;
                    case 'b':
                        times[1]++;
                        break;
                    case 'c':
                        times[2]++;
                        break;
                    case 'd':
                        times[3]++;
                        break;
                    case 'e':
                        times[4]++;
                        break;
                    case 'f':
                        times[5]++;
                        break;
                    case 'g':
                        times[6]++;
                        break;
                    case 'h':
                        times[7]++;
                        break;
                    case 'i':
                        times[8]++;
                        break;
                    case 'j':                     
                        times[9]++;
                        break;
                    case 'k':
                        times[10]++;
                        break;
                    case 'l':
                        times[11]++;
                        break;
                    case 'm':
                        times[12]++;
                        break;
                    case 'n':
                        times[13]++;
                        break;
                    case 'o':
                        times[14]++;
                        break;
                    case 'p':
                        times[15]++;
                        break;
                    case 'q':
                        times[16]++;
                        break;
                    case 'r':
                        times[17]++;
                        break;
                    case 's':
                        times[18]++;
                        break;
                    case 't':
                        times[19]++;
                        break;
                    case 'u':
                        times[20]++;
                        break;
                    case 'v':
                        times[21]++;
                        break;
                    case 'w':
                        times[22]++;
                        break;
                    case 'x':
                        times[23]++;
                        break;
                    case 'y':
                        times[24]++;
                        break;
                    case 'z':
                        times[25]++;
                        break;
                    default:
                        break;
                }
            }
            #endregion
            Console.WriteLine();
            for (int i = 0; i < letter.Length; i++)
            {
                if (times[i] >= 1)
                {
                    Console.Write("{0} {1} times", letter[i], times[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}