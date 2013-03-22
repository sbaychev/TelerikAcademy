using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartesianOne
{
    class CartesianOne
    {
        static void Main(string[] args)
        {
            /*Input data is being read from the console. 
The number X is on the first input line.
The number Y is on the second input line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
On the only output line you must print an integer number between 0 and 6, depending on the location of the given point in the coordinate system.
Constraints
•	The numbers X and Y are numbers between -2 000 000 000 001 337 and 2 000 000 000 001 337, inclusive.
•	Allowed working time for your program: 0.25 seconds.
•	Allowed memory: 16 MB.
*/
            string num = Console.ReadLine();
            long xCoor = long.Parse(num);
            string num1 = Console.ReadLine();
            long yCoor = long.Parse(num1);
            if (xCoor == 0 && yCoor == 0)
            {
                Console.WriteLine("0");
            }
            else if ((xCoor > 0 && xCoor < 2000000000001337) && (yCoor > 0 && yCoor < 2000000000001337) )
            {
                Console.WriteLine("1");
            }
            else if ((xCoor > -2000000000001337 && xCoor < 0) && (yCoor > 0 && yCoor < 2000000000001337))
            {
                Console.WriteLine("2");
            }
            else if ((xCoor > -2000000000001337 && xCoor < 0) && (yCoor < 0 && yCoor > -2000000000001337))
            {
                Console.WriteLine("3");
            }
             else if ((xCoor > 0 && xCoor < 2000000000001337) && (yCoor < 0 && yCoor > -2000000000001337))
            {
                Console.WriteLine("4");
            }
             else if (xCoor == 0 && yCoor < 2000000000001337)
            {
                Console.WriteLine("5");
            }
            else if (xCoor < 2000000000001337 && yCoor == 0)
            {
                Console.WriteLine("6");
            }
        }
    }
}
