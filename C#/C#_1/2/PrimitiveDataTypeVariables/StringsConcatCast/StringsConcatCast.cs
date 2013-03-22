using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsConcatCast
{
    class StringsConcatCast
    {
        static void Main(string[] args)
        {
            /*Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it 
             * with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and 
             * initialize it with the value of the object variable (you should perform type casting).*/

            string varString1 = "Hello";
            string varString2 = "World";
            object varObject1 = varString1 + " " + varString2;
            string varString3 = (string)varObject1;

            Console.WriteLine("The respective variables that we have declared are as follows: \n\nvarString1 = {0}, varString2 = {1}, varObject1 = {2} \n\nand varString3 = {3}", varString1, varString2, varObject1, varString3);
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
