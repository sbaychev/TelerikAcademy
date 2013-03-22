using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((35 / (ulong)Math.Pow(10, 35.ToString().Length - 1)));
        }
    }
}
