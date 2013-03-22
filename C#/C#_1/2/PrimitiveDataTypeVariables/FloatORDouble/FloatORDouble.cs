using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloatORDouble
{
    class FloatORDouble
    {
        /*Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
         * 34.56 7839023, 12.345, 8923.1234857, 3456.091 ? */

        static void Main(string[] args)
        {
            float floatV1= 12.345f;
            float floatV2 = 3456.091f;
            double doubleV1= 34.567839023d;
            double doubleV2= 8923.1234857d;
            
            Console.WriteLine("floatValue1 is {0}\n\nfloatValue2 is {1}\n\ndoubleValue1 is {2}\n\ndoubleValue2 is {3}", floatV1,floatV2,doubleV1,doubleV2);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
