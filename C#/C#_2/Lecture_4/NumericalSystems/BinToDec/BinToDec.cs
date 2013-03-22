using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDec
{
    class BinToDec
    {
        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to their decimal representation.
          Console.WriteLine(Convert.ToByte(Console.ReadLine(), 2));//does the job all in one, make sure that you are entering 1 and 0 first               
        }
    }
}
