using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullValuesIntDouble
{
    class NullValuesIntDouble
    {
        static void Main(string[] args)
        {
            /*Create a program that assigns null values to an integer and to double variables. Try to print them on the console,
             * try to add some values or the null literal to them and see the result*/
            int? varInt = null;
            double? varDouble = null;
            int? someValueThree = 1;
            Console.WriteLine("After the first intilization, the variables are as follows: Integer?:{0}, Double?:{1}\nand the nonNull Integer:{2}",
                varInt, varDouble, someValueThree);
            
            int someValueOne = 1;
            someValueThree = someValueThree + varInt;
            double someValueTwo = 2.0;
            varInt = varInt + someValueOne;
            varDouble = varDouble + someValueTwo;

            Console.WriteLine("\nAfter the second intilization, the variables are as follows: Integer?:{0}, Double?:{1}\nand the nonNull Integer:{2}",
                varInt, varDouble, someValueThree);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(); 
        }
    }
}