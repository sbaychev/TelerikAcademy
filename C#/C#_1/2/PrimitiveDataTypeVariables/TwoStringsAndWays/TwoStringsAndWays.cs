using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoStringsAndWays
{
    class TwoStringsAndWays
    {
        static void Main(string[] args)
        {
            /*Declare two string variables and assign them with following value: 
             * The "use" of quotations causes difficulties.
             * Do the above in two different ways: with and without using quoted strings.*/
            string varString1 = "The \"use\" of quotations causes difficulties.";
            string varString2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("The respective use of the two options produces the following:\n\n{0}\nand\n{1}",varString1, varString2);
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
