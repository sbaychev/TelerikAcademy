using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoIntExchVal
{
    class TwoIntExchVal
    {
        static void Main(string[] args)
        {
            /*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.*/
            int varInt1 = 5;
            int varInt2 = 10;
            Console.WriteLine("After the first intilization, the variables are as follows:\n\ninteger variable one = {0} and integer variable two = {1}", varInt1, varInt2);
            int varIntTemp = varInt1;
            varInt1 = varInt2;
            varInt2 = varIntTemp;
            Console.WriteLine("\nAfter the second intilization, the variables are as follows:\n\ninteger variable one = {0} and integer variable two = {1}", varInt1, varInt2);
            Console.Write("\nPress any key to exit.");
            Console.ReadKey(); 
        }
    }
}
